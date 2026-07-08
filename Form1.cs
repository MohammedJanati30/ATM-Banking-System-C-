using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace windosformATM
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OfficeOpenXml.ExcelPackage.License.SetNonCommercialPersonal("ATM_Project");

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string Account = textboxPN.Text.Trim();

            if (!short.TryParse(texboxPassword.Text, out short Password))
            {
                MessageBox.Show("Password must be a number");
                return;
            }

            clsATMService.CurrentUser = clsATMService.Find(Account, Password);

            if (clsATMService.CurrentUser != null)
            {
                
                ATM_Transaction frm =
                    new ATM_Transaction();

                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Not Success");
            }
        }
    }
}
