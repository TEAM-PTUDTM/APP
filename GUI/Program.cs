using GUI.LayoutGUI;
using System;
using System.Windows.Forms;

namespace GUI
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static FormMain mainForm = null;
        public static FormLogin loginForm = null;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            loginForm = new FormLogin();
            Application.Run(loginForm);
        }
    }
}
