using System;
using System.Windows.Forms;

namespace AW.GUI
{
    public partial class UpdateWorkerInfoForm : Form
    {
        public static UpdateWorkerInfoForm Instance;

        public UpdateWorkerInfoForm()
        {
            Instance = this;
            InitializeComponent();
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(NewPassowrdTextBox.Text) && 
               !string.IsNullOrWhiteSpace(NewPassowrdTextBox.Text))
            {
                if(NewPassowrdTextBox.Text != NewPasswordAgainTextBox.Text)
                {
                    MessageBox.Show("Пароли не совпадают!");
                    return;
                }
            }

            Enabled = false;
            WaitForm.Instance.Show();

            await Program.DataManager.UpdateWorkerInfoAsync(NewPassowrdTextBox.Text,
                                                      NameTextBox.Text,
                                                      MidNameTextBox.Text,
                                                      LastNameTextBox.Text);

            WaitForm.Instance.Hide();
            Enabled = true;

            CloseForm();
        }

        private void ButtonCancel_Click(object sender, EventArgs e) 
        {
            CloseForm();
        }

        private void UpdateWorkerInfoForm_VisibleChanged(object sender, EventArgs e)
        {
            Clear();
            LoadData();
        }

        private void CloseForm()
        {
            Clear();
            MainForm.Instance.Enabled = true;
            MainForm.Instance.Show();
            MainForm.Instance.Activate();
            Hide();
        }

        private async void LoadData()
        {
            Enabled = false;
            WaitForm.Instance.Show();

            var w = await Program.DataManager.GetWorkerInfoAsync();

            this.Text = w.Login;
            LastNameTextBox.Text = w.LastName;
            NameTextBox.Text = w.FirstName;
            MidNameTextBox.Text = w.MiddleName;

            WaitForm.Instance.Hide();
            Enabled = true;
        }

        private void Clear()
        {
            this.Text = "UpdateWorkerInfoForm";
            NameTextBox.Text = "";
            LastNameTextBox.Text = "";
            MidNameTextBox.Text = "";
            NewPassowrdTextBox.Text = "";
            NewPasswordAgainTextBox.Text = "";
        }        
    }
}
