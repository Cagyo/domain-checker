using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DomainChecker
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            bool Ready = true;
            Form1 MainWindow = new Form1(ref Ready);
            if (Ready == true)
            {
                Application.Run(MainWindow);
            }
            else
            {
                Application.ExitThread();
            }
        }
    }
}
