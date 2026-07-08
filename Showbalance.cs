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
    public partial class Showbalance : Form
    {
        public Showbalance()
        {
            InitializeComponent();
        }

        private void Showbalance_Load(object sender, EventArgs e)
        {
            
            this.StartPosition = FormStartPosition.CenterScreen;
            lban.Text = clsATMService.CurrentUser.AccountNumber.ToString();
            lbBalanc.Text = clsATMService.CurrentUser.Balance.ToString() + " " + "$";
         
            lbfullname.Text = clsATMService.CurrentUser.FullName().ToString();
            lbPh.Text = clsATMService.CurrentUser.Phone.ToString();
            LbdataTime.Text = clsATMService.DateTimeByNumber();
            lbDateTimebystring.Text = clsATMService.DateTimeFromString();



        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbBalance_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATM_Transaction frm = new ATM_Transaction();
            frm.Show();
            this.Hide();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lbfn_Click(object sender, EventArgs e)
        {

        }

        private void dataTime_Click(object sender, EventArgs e)
        {

        }
    }
}
