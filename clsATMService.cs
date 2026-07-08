using OfficeOpenXml;
using System;
using System.IO;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using windosformATM;

internal class clsATMService : clsPersone
{
   static  FileInfo file = new FileInfo(@"C:\Users\ThinkPad\Desktop\Data\clientss.xlsx");
    private DateTime CurrentDate = DateTime.Now; // Current DateTime

    public static clsATMService CurrentUser;  // Current User In Programe 
    public string AccountNumber = null;
    public short? Password = null;
    public float? Balance = null;

    public clsATMService(
        string firstname,
        string lastname,
        string phone,
        string accountnumber,
        short password,
        float balance)
        : base(firstname, lastname, phone)
    {
        AccountNumber = accountnumber;
        Password = password;
        Balance = balance;
    }
    private static bool _IsWorkSheetExists()
    {
        using (ExcelPackage package = new ExcelPackage(file))
        {
            if (package.Workbook.Worksheets.Count == 0)
            {
                MessageBox.Show("No worksheet found!");
                return false;
            }

            ExcelWorksheet ws =
                package.Workbook.Worksheets["Feuil1"];

            if (ws == null)
            {
                MessageBox.Show("Worksheet Feuil1 not found!");
                return false;
            }
        }

        return true;
    }

    private static bool _IsFileExists()
    {
        if (!file.Exists)
        {
            MessageBox.Show("Excel file not found!");
            MessageBox.Show(file.FullName);
            return false;
        }

        // ⚠️ مهم ترجع النتيجة
        return _IsWorkSheetExists();
    }
    public static string  DateTimeFromString()
    {
        string Year = DateTime.Now.Year.ToString();
       
        return $"{Year} / {DateTime.Now:MMMM} / {DateTime.Now:dddd}";
    }

    public static string  DateTimeByNumber()
    {
        return DateTime.Now.ToString("yyyy /MM /dd");
    }
    public static clsATMService Find(
        string PIN,
        short Password )
    {
        

        using (ExcelPackage package = new ExcelPackage(file))
        {
            ExcelWorksheet ws =  package.Workbook.Worksheets["Feuil1"];

           
            if (ws.Dimension == null)
                return null;

            int rows = ws.Dimension.Rows;

            for (int i = 2; i <= rows; i++)
            {
                string accExcel = ws.Cells[i, 1].Text;
                
                
                   
                    if (short.TryParse(ws.Cells[i, 2].Text, out short passExcel))
                    {
                        if (PIN == accExcel &&
                      Password == passExcel)
                        {
                            return new clsATMService(
                                ws.Cells[i, 3].Text,
                                ws.Cells[i, 4].Text,
                                ws.Cells[i, 5].Text,
                                ws.Cells[i, 1].Text,
                                passExcel,
                                Convert.ToSingle(ws.Cells[i, 6].Text) // return Object By Data 
                            );
                        }
                       
                    }
                    else
                    {

                        MessageBox.Show("Password invalide , try agin");
                    
                    }

                
            }
        }

      
        return null;  // Return Empty data 
    }
    public static clsATMService Find(
      string PIN)
    {


        using (ExcelPackage package = new ExcelPackage(file))
        {
            ExcelWorksheet ws = package.Workbook.Worksheets["Feuil1"];


            if (ws.Dimension == null)
                return null;

            int rows = ws.Dimension.Rows;

            for (int i = 2; i <= rows; i++)
            {
                string accExcel = ws.Cells[i, 1].Text;


                short password = Convert.ToInt16(ws.Cells[i, 2].Text.Trim());


                if (PIN == accExcel)

                {
                    return new clsATMService(
                        ws.Cells[i, 3].Text,
                        ws.Cells[i, 4].Text,
                        ws.Cells[i, 5].Text,
                        ws.Cells[i, 1].Text,
                    password,


                        Convert.ToSingle(ws.Cells[i, 6].Text) // return Object By Data 
                    );
                }




            }
        }




            return null;  // Return Empty data 
        
    }



    public static bool CheckLogin(string Account, short Password)
    {
        CurrentUser = Find(Account, Password); 

        return CurrentUser != null;
    }

    public float GetBalance()
    {
        return CurrentUser.Balance.Value;
    }


    public void _SaveBalanceToExcel()
    {
        // Path ديال ملف Excel
        string filePath = @"C:\Users\ThinkPad\Desktop\Data\clientss.xlsx";

        try
        {
            // 1- التأكد أن الملف موجود
            if (!File.Exists(filePath))
            {
                MessageBox.Show("Excel file not found!");
                return;
            }

            // 2- إنشاء نسخة احتياطية قبل أي تعديل
            string backupPath = @"C:\Users\ThinkPad\Desktop\Data\clientss_Backup.xlsx";
            File.Copy(filePath, backupPath, true);

            // 3- فتح ملف Excel
            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
            {
                // 4- الحصول على أول Worksheet
                ExcelWorksheet sheet = package.Workbook.Worksheets[0];

                // 5- التأكد أن الـ Worksheet موجود
                if (sheet == null)
                {
                    MessageBox.Show("Worksheet not found!");
                    return;
                }

                // 6- التأكد أن الـ Worksheet فيها بيانات
                if (sheet.Dimension == null)
                {
                    MessageBox.Show("Worksheet is empty!");
                    return;
                }

                bool Found = false;

                // 7- البحث عن الحساب الحالي
                for (int row = 2; row <= sheet.Dimension.End.Row; row++)
                {
                    if (sheet.Cells[row, 1].Text == AccountNumber)
                    {
                        // تحديث الرصيد
                        sheet.Cells[row, 6].Value = Balance;

                        Found = true;
                        break;
                    }
                }

                // 8- إذا الحساب غير موجود
                if (!Found)
                {
                    MessageBox.Show("Account not found.");
                    return;
                }

                // 9- حفظ التعديلات
                package.Save();
            }
        }
        catch (Exception ex)
        {
            // إظهار سبب الخطأ
            MessageBox.Show("Error : " + ex.Message);
        }
    }
    public    bool IsBalanceGreaterThanAmount(int Amount)
    {

        return CurrentUser.Balance > Amount;

    }
    private bool _UpdateBalance(int Amount)
    {
        if (!AskToConfireme())
            return false;

        Balance += Amount;
        

               _SaveBalanceToExcel();
        if (Amount < 0)
        {
            clsTransactionAddToHistory.SaveHistory(Math.Abs(Amount), "Withdrawal");
        }
        if (Amount> 0)
        {
            clsTransactionAddToHistory.SaveHistory(Amount, "Deposit");
        }

        return true;
    }
    public static bool AskToConfireme()
    {
        DialogResult result = MessageBox.Show(
    "Are you sure you want to perform this operation?",
    "Confirm",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Question);

        return result == DialogResult.Yes;

    }
    public  void QuickWithDarw(int Amount)
   
    {
        if (!IsBalanceGreaterThanAmount(Amount))
        {
            MessageBox.Show("Amount Is Greater Than Your Current Balance");
            return;
        }

        if (_UpdateBalance(-Amount))
            MessageBox.Show("Operation Completed Successfully");
    }

    public void Deposit(int Amount)
    {

        if (_UpdateBalance(Amount))
            MessageBox.Show("Operation Completed Successfully");
    }

}