using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace DOWS_SmokeTest.com.DOWS.Utils
{
    class WriteExcelNew
    {


        Excel.Application xlApp;

        Excel.Workbook workbook = null;
        Excel.Worksheet worksheet = null;
        Hashtable sheets;

        //Open .xlsx file in the given path
        public void OpenExcel(string xlFilePath)
        {

            xlApp = new Excel.Application();


            //workbooks = xlApp.Workbooks;
            workbook = xlApp.Workbooks.Open(@xlFilePath, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);

            //workbooks.Open(@"‪C:/Automation/DUNextGen/TestData/XlFile.xlsx");
            sheets = new Hashtable();
            int count = 1;
            // Storing worksheet names in Hashtable.
            foreach (Excel.Worksheet sheet in workbook.Sheets)
            {
                sheets[count] = sheet.Name;
                count++;
            }
        }

        public void Write(string excelPath, string sheetName, int rowNum, string testStatus)
        {
            OpenExcel(excelPath);

            if (sheets.ContainsValue(sheetName))
            {
                int sheetValue = GetSheet(sheetName);
                worksheet = workbook.Worksheets[sheetValue] as Excel.Worksheet;
                // Excel.Range range = worksheet.UsedRange;

                worksheet.Cells[rowNum, 6] = testStatus;

            }
            else
            {
                Console.Write("Sheet is not found");
            }
            save();
            close();
        }

        public void save()
        {
            xlApp.ActiveWorkbook.Save();
        }
        public void close()
        {
            xlApp.ActiveWorkbook.Close();
        }


        //Open Sheet using Sheet Name
        public int GetSheet(string sheetName)
        {
            int sheetValue = 0;

            foreach (DictionaryEntry sheet in sheets)
            {
                if (sheet.Value.Equals(sheetName))
                {
                    sheetValue = (int)sheet.Key;
                }
            }
            return sheetValue;
        }

        // To get all the values in a partiular column
        public List<string> GetDataByCol(string Path, string sheetName, string colName)
        {
            OpenExcel(Path);
            int rowCount = GetSheetRowCount("Sheet1");

            List<string> value = new List<string>();
            int colNumber = 0;

            if (sheets.ContainsValue(sheetName))
            {
                int sheetValue = GetSheet(sheetName);
                Console.WriteLine("Sheet Value" + sheetValue);
                worksheet = workbook.Worksheets[sheetValue] as Excel.Worksheet;
                Excel.Range range = worksheet.UsedRange;

                for (int i = 1; i <= range.Columns.Count; i++)
                {
                    string colNameValue = Convert.ToString((range.Cells[1, i] as Excel.Range).Value2);

                    if (colNameValue.ToLower() == colName.ToLower())
                    {
                        colNumber = i;
                        break;
                    }
                }
                for (int row = 2; row <= rowCount; row++)
                    value.Add(Convert.ToString((range.Cells[row, colNumber] as Excel.Range).Value2));
            }
            // CloseExcel();
            return value;
        }

        //To get the no of rows in an excel sheet
        public int GetSheetRowCount(string sheetName)
        {
            if (sheets.ContainsValue(sheetName))
            {
                int sheetValue = GetSheet(sheetName);
                worksheet = workbook.Worksheets[sheetValue] as Excel.Worksheet;
                Excel.Range range = worksheet.UsedRange;
                return range.Rows.Count;
            }
            else
                return 0;
        }

    }
}
