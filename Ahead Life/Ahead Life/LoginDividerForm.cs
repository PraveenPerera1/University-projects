using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahead_Life
{
    public partial class LoginDividerForm : Form
    {
        
        public LoginDividerForm()
        {
            InitializeComponent();
            string UserId = textBoxUserID.Text;
            string Password = textBoxPassword.Text;
        }

        private void buttonEmpLogin_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            LoginServayForm loginServayForm = new LoginServayForm();
            loginServayForm.Show();
        }

        private void buttonAdminLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            empCheckinForm ECF=new empCheckinForm();
            ECF.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
