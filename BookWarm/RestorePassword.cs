using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class RestorePassword : Form
    {
        public RestorePassword()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            // Отримуємо список всіх відкритих форм
            Form[] openForms = Application.OpenForms.Cast<Form>().ToArray();

            // Закриваємо кожну з них
            foreach (var form in openForms)
            {
                form.Close();
            }

            // Завершуємо додаток
            Application.Exit();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            // Закрити поточну форму реєстрації
            this.Close();

            // Створити і показати форму авторизації (передбачається, що ця форма називається "LoginForm")
            Login Login = new Login();
            Login.Show();
        }
    }
}
