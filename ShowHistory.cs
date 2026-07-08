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
    public partial class ShowHistory : Form
    {
        public ShowHistory()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        private void LoadHistoryToListView()
        {
            listView1.Items.Clear();

            List<ClssLoadDataHistory> historyList = ClssLoadDataHistory.LoadHistory();

            foreach (ClssLoadDataHistory item in historyList)
            {
                if (item.SourceAccount != clsATMService.CurrentUser.AccountNumber)
                    continue;

                    ListViewItem lv = new ListViewItem(item.SourceAccount);
            
                    lv.SubItems.Add(item.DestinationName);
                    lv.SubItems.Add(item.DestinationAccount);
                    lv.SubItems.Add(item.Amount.ToString());
                    lv.SubItems.Add(item.OperationType);
                    lv.SubItems.Add(item.TransactionDate.ToString("dd/MM/yyyy HH:mm:ss"));

                    listView1.Items.Add(lv);
              
                
            }
        }
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
         
        }

        private void listView1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
         
        }

        private void ShowHistory_Load(object sender, EventArgs e)
        {
            lbdateTime.Text = clsATMService.DateTimeFromString();
            lbFullName.Text = clsATMService.CurrentUser.FullName();
            LoadHistoryToListView();

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ATM_Transaction frm = new ATM_Transaction();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();

        }
    }
}
