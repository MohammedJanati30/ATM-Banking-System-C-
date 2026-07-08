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
    public partial class Deposit : Form
    {
        public Deposit()
        {
            InitializeComponent();
        }

        private void Deposit_Load(object sender, EventArgs e)
        {

            //CurrentAmount.Text = clsATMService.CurrentUser.Balance.ToString();
            lbfullname.Text = clsATMService.CurrentUser.FullName();
            lbdatetime.Text = clsATMService.DateTimeByNumber();
            lbcurrentbalance.Text = clsATMService.CurrentUser.Balance.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxDepositAmount.Text , out int Amount))
            {
                clsATMService.CurrentUser.Deposit(Amount);
            }
            else
            {
               
                    MessageBox.Show("Please enter a valid number");
                
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ATM_Transaction Frm = new ATM_Transaction();
            Frm.Show();
            this.Hide();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login Frm = new Login();
            Frm.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            ATM_Transaction Frm = new ATM_Transaction();
            Frm.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Login Frm = new Login();
            Frm.Show();
            this.Hide();
        }
    }
}
