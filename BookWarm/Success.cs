using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BookWarm
{
    public partial class Success : Form
    {
        private Timer timer;
        private string username;
        public Success() // Додайте параметр username до конструктора
        {
            InitializeComponent();
            this.username = username;
            // Створення і налаштування таймера
            timer = new Timer();
            timer.Interval = 3000; // (3 секунди)
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop(); // Зупиніть таймер
            Main mainForm = new Main(); // Передайте username в конструктор головної форми
            mainForm.Show();
            this.Close(); // Закрити поточну форму Success
        }
    }
}
