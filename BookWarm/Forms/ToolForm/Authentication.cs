using ComponentFactory.Krypton.Toolkit;
using System;
using System.Windows.Forms;

namespace BookWarm
{
    public partial class Authentication : KryptonForm
    {
        public Authentication()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Login login = new Login(); 
            login.Show(); 
            this.Hide();
        }

        private void Registration_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration(); 
            registration.Show(); 
            this.Hide(); 
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bookWarmDBDataSet);

        }

        private void Authentication_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.bookWarmDBDataSet.Users);

        }
    }
}
