using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windosformATM
{

    internal class clsTransfer : clsTransactionAddToHistory
    {
        public static clsATMService CurrentAccountToTransfer;

        public static clsATMService FindAccountNumberToTransfer(string AccountNumber)
        {
            CurrentAccountToTransfer =
                clsATMService.Find(AccountNumber);
           
            

            return CurrentAccountToTransfer;
        }
        public static bool IsNotEmpty(string AccountNumber)
        {
            return FindAccountNumberToTransfer(AccountNumber) != null;
        }

        private static bool IsTheSameObject()
        {
            return clsATMService.CurrentUser.AccountNumber ==
                   CurrentAccountToTransfer.AccountNumber;
        }

        public static void TrasferAmount(string Account, int Amount)
        {
            if (!IsNotEmpty(Account))
            {
                MessageBox.Show("No account found with this account number.");
                return;
            }

            if (IsTheSameObject())
            {
                MessageBox.Show("You cannot transfer money to the same account.");
                return;
            }


            if (!clsATMService.CurrentUser.IsBalanceGreaterThanAmount(Amount))
            {
                MessageBox.Show("Insufficient balance.");
                return;
            }
            if (!clsATMService.AskToConfireme()) return;

          
             
            clsATMService.CurrentUser.Balance -= Amount;
            clsATMService.CurrentUser._SaveBalanceToExcel();

            CurrentAccountToTransfer.Balance += Amount;
            CurrentAccountToTransfer._SaveBalanceToExcel();
            clsTransactionAddToHistory.SaveHistory(
     Amount,
     "Transfer",
     clsTransfer.CurrentAccountToTransfer.FullName(),
     clsTransfer.CurrentAccountToTransfer.AccountNumber);


            MessageBox.Show("Transfer completed successfully.");
          

        }

       
    }
}
