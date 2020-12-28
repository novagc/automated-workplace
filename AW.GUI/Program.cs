using System;
using System.Windows.Forms;

namespace AW.GUI
{
    static class Program
    {
        public static Core.DataManager DataManager { get; set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            new WaitForm();
            new MainForm();
            new UpdateWorkerInfoForm();

            Application.Run(new AuthForm());
        }
    }
}
