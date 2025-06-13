using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Закупки_Win_Forms
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new RegisterForm());
            //Application.Run(new SuppliersMainForm());
            //Application.Run(new SuppliersWriteableForm());

            Application.Run(new MainForm());

        }
    }
}
