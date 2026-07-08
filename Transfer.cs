using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windosformATM
{
    public partial class Transfer : Form
    {
        public Transfer()
        {
            InitializeComponent();
        }

        private void textBoxAccountNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string AccountNumber = textBoxAccountNumber.Text.Trim();
            int Amount = Convert.ToInt32(textBoxAmount.Text.Trim());

            clsTransfer.TrasferAmount(AccountNumber, Amount);
           

           
           

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ATM_Transaction Frm = new ATM_Transaction();
            Frm.Show();
          
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Login Frm = new Login();
            Frm.Show();
            
        }

        private void textBoxaAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void Transfer_Load(object sender, EventArgs e)
        {
            lbdatetime.Text = clsATMService.DateTimeByNumber();
            lbfullname.Text = clsATMService.CurrentUser.FullName();
               
                   }
    }
}
