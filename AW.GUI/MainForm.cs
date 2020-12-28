using AW.Data.Models;
using AW.Data.Models.Enums;
using System;
using System.Linq;
using System.Security;
using System.Windows.Forms;

namespace AW.GUI
{
    public partial class MainForm : Form
    {
        public static MainForm Instance;

        private bool create;
        private bool load;
        private Order currentOrder;
        private Order[] orders;
        private Worker[] workers;

        private Control[] orderControls;

        public MainForm()
        {
            Instance = this;
            InitializeComponent();
            Closed += (_, __) => { Application.Exit(); };

            orderControls = new Control[]
            {
                titleBox,
                descriptionBox,
                priceBox,
                statusBox,
                workerComboBox,
                saveOrderButton,
                setStatusArchivedButton,
                setStatusFinishedButton,
                setStatusInWorkButton,
                cancelButton
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void MainForm_VisibleChanged(object sender, EventArgs e)
        {
            Clear();
            LoadData();
        }

        private async void LoadData()
        {
            workers = await Program.DataManager.GetWorkersAsync();
            orders = await Program.DataManager.GetOrdersAsync();

            orderList.Items.Clear();
            orderList.Items.AddRange(orders);

            load = true;
            workerComboBox.Items.Clear();
            workerComboBox.Items.AddRange(workers);
            load = false;
        }

        private void Clear()
        {
            currentOrder = null;
            titleBox.Text = "";
            descriptionBox.Text = "";
            priceBox.Text = "";
            statusBox.Text = "";
            workerComboBox.SelectedIndex = -1;

            LockControls();
        }

        private void LockControls()
        {
            foreach (var orderControl in orderControls)
            {
                orderControl.Enabled = false;
            }
        }

        private void UnlockControls()
        {
            foreach (var orderControl in orderControls)
            {
                orderControl.Enabled = true;
            }
        }

        private void orderList_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clear();
            create = false;
            foreach (var orderControl in orderControls)
            {
                orderControl.Enabled = true;
            }

            UpdateCurrentOrder();
        }

        private void UpdateCurrentOrder()
        {
            if (orderList.SelectedIndex != -1)
            {
                load = true;

                currentOrder = orderList.Items[orderList.SelectedIndex] as Order;

                titleBox.Text = currentOrder.Title;
                descriptionBox.Text = currentOrder.Description;
                priceBox.Text = currentOrder.Price.ToString();
                statusBox.Text = currentOrder.Status.ToString();

                if (currentOrder.WorkerId != null)
                {
                    var temp = workers.FirstOrDefault(x => x.Id == currentOrder.WorkerId);
                    if (temp != null)
                    {
                        workerComboBox.SelectedIndex = workerComboBox.Items.IndexOf(temp);
                    }
                }

                load = false;
            }
            else
            {
                Clear();
                LoadData();
            }
        }

        private async void setStatusInWorkButton_Click(object sender, EventArgs e)
        {
            if (currentOrder != null)
            {
                Enabled = false;
                WaitForm.Instance.Show();
                
                try
                {
                    await Program.DataManager.AcceptOrderAsync(currentOrder.Id);
                    currentOrder.Status = Status.InWork;
                    WaitForm.Instance.Hide();
                    Enabled = true;
                }
                catch (SecurityException ex)
                {
                    WaitForm.Instance.Hide();
                    MessageBox.Show(ex.Message);
                    Enabled = true;
                }

                UpdateCurrentOrder();
                Activate();
            }
            else
            {
                MessageBox.Show("Не выбран ни один заказ");
            }
        }

        private async void setStatusFinishedButton_Click(object sender, EventArgs e)
        {
            if (currentOrder != null)
            {
                Enabled = false;
                WaitForm.Instance.Show();

                try
                {
                    await Program.DataManager.FinishOrderAsync(currentOrder.Id);
                    currentOrder.Status = Status.Finished;
                    WaitForm.Instance.Hide();
                    Enabled = true;
                }
                catch (SecurityException ex)
                {
                    WaitForm.Instance.Hide();
                    MessageBox.Show(ex.Message);
                    Enabled = true;
                }

                UpdateCurrentOrder();
                Activate();
            }
            else
            {
                MessageBox.Show("Не выбран ни один заказ");
            }
        }

        private async void setStatusArchivedButton_Click(object sender, EventArgs e)
        {
            if (currentOrder != null)
            {
                Enabled = false;
                WaitForm.Instance.Show();

                try
                {
                    await Program.DataManager.ArchiveOrderAsync(currentOrder.Id);
                    Clear();
                    LoadData();
                    WaitForm.Instance.Hide();
                    Enabled = true;
                }
                catch (SecurityException ex)
                {
                    WaitForm.Instance.Hide();
                    MessageBox.Show(ex.Message);
                    Enabled = true;
                }

                UpdateCurrentOrder();
                Activate();
            }
            else
            {
                MessageBox.Show("Не выбран ни один заказ");
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            UpdateCurrentOrder();
            Activate();
        }

        private async void saveOrderButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            WaitForm.Instance.Show();
            if (string.IsNullOrEmpty(titleBox.Text))
            {
                WaitForm.Instance.Hide();
                MessageBox.Show("Заголовок не может быть пустым");
            }
            else if (!uint.TryParse(priceBox.Text, out var price))
            {
                WaitForm.Instance.Hide();
                MessageBox.Show("Цена должна быть числом, которое больше 0");
            }
            else
            {
                try
                {
                    if (create)
                    {
                        await Program.DataManager.CreateOrderAsync(titleBox.Text, descriptionBox.Text, price);
                        Clear();
                        LoadData();
                        WaitForm.Instance.Hide();
                    }
                    else
                    {
                        await Program.DataManager.UpdateOrderInfoAsync(currentOrder.Id, titleBox.Text, descriptionBox.Text, price);
                        currentOrder.Title = titleBox.Text;
                        currentOrder.Description = descriptionBox.Text;
                        currentOrder.Price = price;
                        WaitForm.Instance.Hide();
                    }
                }
                catch (SecurityException exception)
                {
                    WaitForm.Instance.Hide();
                    MessageBox.Show(exception.Message);
                    UpdateCurrentOrder();
                }
            }
            Enabled = true;
            Activate();
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            Clear();
            UnlockControls();
            create = true;
            Activate();
        }

        private async void workerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!load)
            {
                if (workerComboBox.SelectedIndex != -1)
                {
                    Enabled = false;
                    WaitForm.Instance.Show();
                    var worker = workerComboBox.Items[workerComboBox.SelectedIndex] as Worker;
                    await Program.DataManager.SetWorkerAsync(currentOrder.Id, worker.Id);
                    WaitForm.Instance.Hide();
                    Enabled = true;
                    Activate();
                }
            }
        }

        private void UpdateWorkerInfoButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            UpdateWorkerInfoForm.Instance.Enabled = true;
            UpdateWorkerInfoForm.Instance.Show();
            UpdateWorkerInfoForm.Instance.Activate();
        }
    }
}
