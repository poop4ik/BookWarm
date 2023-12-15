using ComponentFactory.Krypton.Toolkit;
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
    public partial class AgeCategory : KryptonForm
    {
        private Timer timer;

        public AgeCategory(int ageCategory)
        {
            InitializeComponent();

            ErrorText.Text = $"Вам повинно бути {ageCategory} або більше, щоб переглядати цю книгу.";
            timer = new Timer() { Interval = 3000 };
            timer.Enabled = true;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close(); 
        }
    }
}
