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
    public partial class Authentication : Form
    {
        public Authentication()
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

        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login(); // Створюємо форму авторизації
            login.Show(); // Відкриваємо форму авторизації
            this.Hide(); // Приховуємо поточну форму
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(); // Створюємо форму реєстрації
            registration.Show(); // Відкриваємо форму реєстрації
            this.Hide(); // Приховуємо поточну форму
        }
    }
}
