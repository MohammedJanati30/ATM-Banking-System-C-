using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using windosformATM;
using OfficeOpenXml;
using System.IO;

namespace windosformATM
{
    internal class clsTransactionAddToHistory
    {


        static FileInfo file = new FileInfo(@"C:\Users\ThinkPad\Desktop\Data\Historycal.xlsx");


        public static void SaveHistory(
                    int amount,
    string operationType,

    string destinationName = "N/A",

    string destinationAccount = "null")
        {
            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet sheet = package.Workbook.Worksheets[0];

                int newRow = sheet.Dimension.End.Row + 1;

                sheet.Cells[newRow, 1].Value = clsATMService.CurrentUser.AccountNumber;
                sheet.Cells[newRow, 2].Value = destinationName;
                sheet.Cells[newRow, 3].Value = destinationAccount;
                sheet.Cells[newRow, 4].Value = amount;
                sheet.Cells[newRow, 5].Value = operationType;
                sheet.Cells[newRow, 6].Value = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

                package.Save();
            }

        }
     
        
    }
}

       




    
