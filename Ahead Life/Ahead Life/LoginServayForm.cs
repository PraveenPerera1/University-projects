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
    public partial class LoginServayForm : Form
    {
        public LoginServayForm()
        {
            InitializeComponent();
        }

        private void previousbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDividerForm loginDividerForm = new LoginDividerForm();
            loginDividerForm.Show();
        }
    }
}
