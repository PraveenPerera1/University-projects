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
    public partial class empCheckinForm : Form
    {
        public empCheckinForm()
        {
            InitializeComponent();
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginDividerForm L=new LoginDividerForm();
            L.Show();
        }
    }
}
