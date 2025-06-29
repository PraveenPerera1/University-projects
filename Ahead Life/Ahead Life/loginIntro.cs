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
    public partial class loginIntro : Form
    {
        public loginIntro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDividerForm lDF = new LoginDividerForm();
            lDF.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignInForm inForm = new SignInForm();
            inForm.Show();
        }
    }
}
