using System;
using System.Windows.Forms;
using EmployeeApp.View;
using EquipmentDB.Controller;
using EquipmentDB.Forms;

namespace EquipmentDB
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            var repository = Repository.Instance;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
          
                Application.Run(new MainForm());
           

        }
    }
}
