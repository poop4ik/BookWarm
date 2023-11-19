using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWarm
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Отримуємо ім'я користувача з налаштувань
            string username = Properties.Settings.Default.Username;

            // Якщо ім'я користувача порожнє, викликаємо форму Authentication
            if (string.IsNullOrEmpty(username))
            {
                Application.Run(new Authentication());
            }
            else
            {
                // Якщо ім'я користувача не порожнє, викликаємо форму Main
                Application.Run(new Main(username));
            }

        }
    }
}
