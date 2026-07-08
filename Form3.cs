using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windosformATM
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.Size = new Size(700, 700);
            lbcurrentbalance.Text = clsATMService.CurrentUser.Balance.ToString() + " " + "$";
            lbdatetime.Text = clsATMService.DateTimeByNumber().ToString();
            lbfullname.Text = clsATMService.CurrentUser.FullName();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxNwd.Text, out int Amount))
            {
                clsATMService.CurrentUser.QuickWithDarw(Amount);
            }
            else
            {
                MessageBox.Show("Please enter a valid number");
            }

           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Quick_With_Draw Frm = new Quick_With_Draw();
            Frm.Show();
            this.Hide();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login Frm = new Login();
            Frm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
