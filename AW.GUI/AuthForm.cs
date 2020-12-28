using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AW.Core;

namespace AW.GUI
{
    public partial class AuthForm : Form
    {
        public static AuthForm Instance;

        public AuthForm()
        {
            Instance = this;
            InitializeComponent();
        }

        private async void signInButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(loginBox.Text) && !string.IsNullOrEmpty(passwordBox.Text))
            {
                try
                {
                    Enabled = false;
                    WaitForm.Instance.Show();
                    await Task.Factory.StartNew(() => Program.DataManager = new DataManager(loginBox.Text, passwordBox.Text));
                    WaitForm.Instance.Hide();
                    loginBox.Text = "";
                    passwordBox.Text = "";
                    Hide();
                    MainForm.Instance.Enabled = true;
                    MainForm.Instance.Show();
                }
                catch (AuthenticationException exception)
                {
                    WaitForm.Instance.Hide();
                    Enabled = true;
                    MessageBox.Show(exception.Message);
                    Activate();
                }
        }
            else
            {
                MessageBox.Show("Все поля должны быть заполнены");
            }
}
    }
}
