using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;

namespace windosformATM
{
    internal class ClssLoadDataHistory
    {
        public string SourceAccount { get; set; }
        public string DestinationName { get; set; }
        public string DestinationAccount { get; set; }
        public int Amount { get; set; }
        public string OperationType { get; set; }
        public DateTime TransactionDate { get; set; }

        // Constructor
        public ClssLoadDataHistory(
            string sourceAccount,
            string destinationName,
            string destinationAccount,
            int amount,
            string operationType,
            DateTime transactionDate)
        {
            SourceAccount = sourceAccount;
            DestinationName = destinationName;
            DestinationAccount = destinationAccount;
            Amount = amount;
            OperationType = operationType;
            TransactionDate = transactionDate;
        }

        // Excel File
        static FileInfo file = new FileInfo(@"C:\Users\ThinkPad\Desktop\Data\Historycal.xlsx");

        // Load All History
        public static List<ClssLoadDataHistory> LoadHistory()
        {
            List<ClssLoadDataHistory> HistoryList = new List<ClssLoadDataHistory>();

            using (ExcelPackage package = new ExcelPackage(file))
            {
                ExcelWorksheet sheet = package.Workbook.Worksheets[0];

                if (sheet.Dimension == null)
                    return HistoryList;

                int rows = sheet.Dimension.Rows;

                for (int row = 2; row <= rows; row++)
                {
                    ClssLoadDataHistory history = new ClssLoadDataHistory(
                        sheet.Cells[row, 1].Text,
                        sheet.Cells[row, 2].Text,
                        sheet.Cells[row, 3].Text,
                        Convert.ToInt32(sheet.Cells[row, 4].Text),
                        sheet.Cells[row, 5].Text,
                        Convert.ToDateTime(sheet.Cells[row, 6].Text)
                    );

                    HistoryList.Add(history);
                }
            }

            return HistoryList;
        }
    }
}