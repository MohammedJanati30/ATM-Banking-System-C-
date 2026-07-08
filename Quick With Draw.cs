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
    public partial class Quick_With_Draw : Form
    {
        public Quick_With_Draw()
        {
            InitializeComponent();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void bt1000_Click(object sender, EventArgs e)
        {
            if (clsATMService.CurrentUser == null)
            {
                MessageBox.Show("CurrentUser is null");
                return;
            }
            clsATMService.CurrentUser.QuickWithDarw(1000);
            ATM_Transaction Frm = new ATM_Transaction();
            Frm.Show();
            this.Hide();
        }

        private void Quick_With_Draw_Load(object sender, EventArgs e)
        {
            lbfullname.Text = clsATMService.CurrentUser.FullName().ToString();
            lbcurrentbalance.Text = clsATMService.CurrentUser.Balance.ToString() + " " + "$";
            lbdatetime.Text = clsATMService.DateTimeByNumber();
            

        }

        private void bt100dh_Click(object sender, EventArgs e)
        {
            if (clsATMService.CurrentUser == null)
            {
                MessageBox.Show("CurrentUser is null");
                return;
            }
            clsATMService.CurrentUser.QuickWithDarw(100);
           

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Login Frm = new Login();
            Frm.Show();
            this.Hide();
        }

        private void backtomenue_Click(object sender, EventArgs e)
        {
            ATM_Transaction Frm = new ATM_Transaction();
            Frm.Show();
            this.Hide();

       
        }

        private void lbQuickCurrentBalance_Click(object sender, EventArgs e)
        {

        }

        private void lbFullName_Click(object sender, EventArgs e)
        {

        }

        private void bt300_Click(object sender, EventArgs e)
        {
            if (clsATMService.CurrentUser == null)
            {
                MessageBox.Show("CurrentUser is null");
                return;
            }
            clsATMService.CurrentUser.QuickWithDarw(300);
           
        }

        private void bt4000_Click(object sender, EventArgs e)
        {
            if (clsATMService.CurrentUser == null)
            {
                MessageBox.Show("CurrentUser is null");
                return;
            }
            clsATMService.CurrentUser.QuickWithDarw(4000);
            
        }

        private void bt2000_Click(object sender, EventArgs e)
        {
            if (clsATMService.CurrentUser == null)
            {
                MessageBox.Show("CurrentUser is null");
                return;
            }
            clsATMService.CurrentUser.QuickWithDarw(2000);
          
        }

        private void bt500_Click(object sender, EventArgs e)
        {
            if (clsATMService.CurrentUser == null)
            {
                MessageBox.Show("CurrentUser is null");
                return;
            }
            clsATMService.CurrentUser.QuickWithDarw(500);
            ATM_Transaction Frm = new ATM_Transaction();
            Frm.Show();
            this.Hide();
        }

        private void FullName_Click(object sender, EventArgs e)
        {

        }
    }
}
