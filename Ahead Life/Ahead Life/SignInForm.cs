using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace Ahead_Life
{
    

    public partial class SignInForm : Form
    {
        config o = new config();
        private void button1_Click(object sender, EventArgs e)
        {
           
        }
        string Sex = "";
        string MaritalStatus = "";
        string Mother = "";
        string Father = "";
        string LivingStatus = "";
        string Religion = "";
        public SignInForm()
        {
            InitializeComponent();
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginIntro loginIntro = new loginIntro();
            loginIntro.Show();
            
        }

        private void Submitbutton_Click(object sender, EventArgs e)
        {
            string Name = textBoxName.Text.ToString();
            string Age=textBoxAge.Text.ToString();
            string EmpId=textBoxID.Text.ToString();
            string Address=textBoxAddress.Text.ToString();
            string PhoneNum=textBoxPhone.Text.ToString();

            switch (comboBoxReligion.SelectedItem.ToString())
            {
                case "Buddhist":
                    Religion = "Buddhist";
                    break;
                case "Hindu":
                    Religion = "Hindu";
                    break;
                case "Islam":
                    Religion = "Islam";
                    break;
                case "Katholic":
                    Religion = "Katholic";
                    break;
                    string BirthDate= dateTimePicker1.Text.ToString();
                    string MothersJob=textBoxMotherJob.Text.ToString();
                    string FathersJob=textBoxFatherJob.Text.ToString();
            }
            try
            {
                if (textBoxID.Text != "" && textBoxName.Text != "")
                {
                    string qry = " INSERT INTO [Table](Name, Age, EmpID , address, Phonenum , Sex , Religion , BirthDate , MaritalStatus , Mother , MothersJob , Father , FathersJob,LivingStatus)VALUES('" + textBoxName.Text + "', '" + textBoxAge.Text + "','" + textBoxID.Text + "','" + textBoxAddress.Text + "','" + textBoxPhone.Text + "','" + Sex + "', '" + comboBoxReligion.Text + "','" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "','" + MaritalStatus + "','" + Mother + "','" + textBoxMotherJob.Text + "','" + Father + "','" + textBoxFatherJob.Text + "','" + LivingStatus + "',  )";
                    SqlCommand cmd = new SqlCommand(qry, o.con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data Stored");
                }
                else
                {
                    MessageBox.Show("All FIELDS ARE REQUIRED");
                }

            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonMale.Checked)
            {
                Sex = radioButtonMale.Text;
            }
            else if(radioButtonFemale.Checked)
            {
                Sex=radioButtonFemale.Text;
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radioButtonDead_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButtonDead.Checked)
            {
                Mother= radioButtonDead.Text;
            }
            else if (radioButtonAlive.Checked)
            {
                Mother= radioButtonAlive.Text;
            }
        }

        private void radioButtonFDead_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonFDead.Checked)
            {
                Father= radioButtonFDead.Text;
            }
            else if (radioButtonFAlive.Checked)
            {
                Father= radioButtonFAlive.Text;
            }
        }

        private void radioButtonManagable_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonManagable.Checked)
            {
                LivingStatus= radioButtonManagable.Text;
            }
            else if (radioButtonUnmanagable.Checked)
            {
                LivingStatus = radioButtonUnmanagable.Text;
            }
            else if (radioButtonLowexpences.Checked)
            {
                LivingStatus=radioButtonLowexpences.Text;
            }
            else if (radioButtonHighexpences.Checked)
            {
                LivingStatus=radioButtonHighexpences.Text;
            }
        }

        private void comboBoxReligion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
