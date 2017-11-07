using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Runtime.InteropServices;

namespace MyExcelClass
{
    class MyExcel
    {
        //User-defined values for printing.
        public enum ShowCommands : int
        {
            SW_HIDE = 0,
            SW_SHOWNORMAL = 1,
            SW_NORMAL = 1,
            SW_SHOWMINIMIZED = 2,
            SW_SHOWMAXIMIZED = 3,
            SW_MAXIMIZE = 3,
            SW_SHOWNOACTIVATE = 4,
            SW_SHOW = 5,
            SW_MINIMIZE = 6,
            SW_SHOWMINNOACTIVE = 7,
            SW_SHOWNA = 8,
            SW_RESTORE = 9,
            SW_SHOWDEFAULT = 10,
            SW_FORCEMINIMIZE = 11,
            SW_MAX = 11
        }

        [DllImport("shell32.dll")]
        static extern IntPtr ShellExecute(
            IntPtr hwnd,
            string lpOperation,
            string lpFile,
            string lpParameters,
            string lpDirectory,
            ShowCommands nShowCmd);

        public MyExcel()
        {
 
        }

        public void PrintReportToExcelContract(string amount,string duration,string interestRate,string otherCondition)
        {
            Excel.Application oXL;
            Excel.Workbook oWB;
            Excel.Worksheet oSheet;
            Excel.Range oRng;
            object oMissing = Missing.Value;

            try
            {
                //Start Excel and get Application object.
                oXL = new Excel.Application();
                oXL.Visible = true;

                //Get a new workbook.
                oWB = oXL.Workbooks._Open(Application.StartupPath + "\\Templates\\Contract.xlsx", oMissing, oMissing, oMissing,
                                          oMissing, oMissing, oMissing, oMissing, oMissing, oMissing,
                                          oMissing, oMissing, oMissing);

                oSheet = (Excel.Worksheet)oWB.ActiveSheet;
                //oSheet.Cells[row,col] = " data "
                oSheet.Cells[5, 6] = DateTime.Now.ToLongDateString(); 
                oSheet.Cells[22,2] = "The Lender hereby agrees to lend the sum of " + amount;
                oSheet.Cells[35, 2] ="This loan shall endure for a period of " + duration;
                oSheet.Cells[39, 2] = "The Borrower shall be obliged to pay interest at the rate of " + interestRate;
                oSheet.Cells[44, 2] = otherCondition;
                if (!System.IO.Directory.Exists("C:\\Loan System Reports\\"))
                    System.IO.Directory.CreateDirectory("C:\\Loan System Reports\\");
                File.WriteAllText("C:\\Loan System Reports\\Readme.txt", "The contract print-outs soft copy will be saved in this destination.");
                oWB.SaveAs("C:\\Loan System Reports" + "\\Contract_" + DateTime.Now.ToShortDateString().Replace("/", "") + DateTime.Now.ToLongTimeString().Replace(":", "") + ".xlsx",
                          oMissing, oMissing, oMissing, oMissing,
                          oMissing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
                          oMissing, oMissing, oMissing, oMissing, oMissing);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        //private void PrintReportToExcel()
        //{
        //    Excel.Application oXL;
        //    Excel.Workbook oWB;
        //    Excel.Worksheet oSheet;
        //    Excel.Range oRng;
        //    object oMissing = Missing.Value;

        //    try
        //    {
        //        //Start Excel and get Application object.
        //        oXL = new Excel.Application();
        //        oXL.Visible = true;

        //        //Get a new workbook.
        //        oWB = oXL.Workbooks._Open(@"C:\reports\report.xlsx", oMissing, oMissing, oMissing,
        //                                  oMissing, oMissing, oMissing, oMissing, oMissing, oMissing,
        //                                  oMissing, oMissing, oMissing);

        //        oSheet = (Excel.Worksheet)oWB.ActiveSheet;
        //        //oSheet.Cells[row,col] = " data "
        //        oSheet.Cells[4, 5] = DateTime.Now.ToLongDateString(); //Print Date on excel row 4, column F (6)

        //        int counter = 8;

        //        //foreach (DataRow row in dataTable.Rows)
        //        //{
        //        //    oSheet.Cells[counter, 2] = row["studentno"].ToString();
        //        //    oSheet.Cells[counter, 3] = row["fname"].ToString() + " " + row["lname"].ToString();
        //        //    oSheet.Cells[counter, 6] = row["course"].ToString();
        //        //    counter++;
        //        //    Excel.Range r = oSheet.get_Range("A" + counter, "F" + counter).EntireRow;
        //        //    r.Insert(Excel.XlInsertShiftDirection.xlShiftDown, oMissing);
        //        //}

        //        oWB.SaveAs(@"C:\reports\report_" + DateTime.Now.Second + ".xlsx", oMissing, oMissing, oMissing, oMissing,
        //                  oMissing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlNoChange,
        //                  oMissing, oMissing, oMissing, oMissing, oMissing);

        //    }
        //    catch (Exception e)
        //    {
        //        MessageBox.Show(e.Message);
        //    }
        //}
        public void Print(string path)
        {
            ShellExecute(IntPtr.Zero, "print", path, "", "", ShowCommands.SW_SHOWNOACTIVATE);
        }
    }
}
