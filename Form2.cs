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
    internal partial class ATM_Transaction : Form
    {
        

        public ATM_Transaction ()
        {
            InitializeComponent();
            
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 Frm = new Form3();
            Frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Deposit Frm = new Deposit();
            Frm.Show();
            this.Hide();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Size = new Size(700, 700);
            this.StartPosition = FormStartPosition.CenterScreen;
            if (clsATMService.CurrentUser != null)
            {
                LbBalance.Text = clsATMService.CurrentUser.Balance.ToString() + " $";
                CurrentName.Text = clsATMService.CurrentUser.FullName();
            }

            LbDataTimeString.Text = clsATMService.DateTimeFromString();
            lbDateTimeNum.Text = clsATMService.DateTimeByNumber();
                
        }
        

        private void LbBalance_Click(object sender, EventArgs e)
        {
          

        }

        private void CurrentName_Click(object sender, EventArgs e)
        {
           
        }

        private void btQuickWithDraw_Click(object sender, EventArgs e)
        {
            Quick_With_Draw frm = new Quick_With_Draw();


            frm.Show();
            this.Hide();
        }

        private void btShwologout_Click(object sender, EventArgs e)
        {
            Login Fm = new Login();
            Fm.Show();
            this.Hide();
        }

        private void btShowBalance_Click(object sender, EventArgs e)
        {
            Showbalance Frm = new Showbalance();
            Frm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Transfer Frm = new Transfer();
            Frm.Show();
            this.Hide();
        }

        private void btShowHistory_Click(object sender, EventArgs e)
        {
            ShowHistory frm = new ShowHistory();
            frm.Show();
          
        }
    }
}
