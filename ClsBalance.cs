using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using windosformATM;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms;




namespace windosformATM
{
    internal class ClsBalance : clsATMService
    {
       
        public ClsBalance(
         string firstname,
         string lastname,
         string phone,
         string accountnumber,
         short password,
         float balance)
         : base(firstname, lastname, phone,
                accountnumber, password, balance)
        {
            
        }
        
     public float GetBalanceFromBaseClass()
        {
            return base.GetBalance();
        }
    }
}