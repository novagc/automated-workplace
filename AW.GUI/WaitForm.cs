using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AW.GUI
{
    public partial class WaitForm : Form
    {
        public static WaitForm Instance;

        public WaitForm()
        {
			Text = "Подождите";
            Instance = this;
            InitializeComponent();
        }

        private void WaitForm_Load(object sender, EventArgs e)
        {

        }
    }
}
