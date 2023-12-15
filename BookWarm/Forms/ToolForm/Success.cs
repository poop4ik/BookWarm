using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class Success : KryptonForm
    {
        private Timer timer;
        private string username;

        public Success() 
        {
            InitializeComponent();
            this.username = username;

            timer = new Timer() { Interval = 3000};
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
