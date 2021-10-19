
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;


namespace DOWS_SmokeTest.com.DOWS.Utils
{
    class ExcelReader
    {

        public static DataTable ExcelToDataTable(string fileName)
        {

            DataTable dataTable = new DataTable();
            try
            {
                using (var stream = File.Open(fileName, FileMode.Open, FileAccess.Read))
                {
                    //Createopenxmlreader via ExcelReaderFactory
                    IExcelDataReader reader = ExcelDataReader.ExcelReaderFactory.CreateReader(stream);

                    var conf = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    };

                    var dataSet = reader.AsDataSet(conf);
                    //Return as DataSet
                    dataTable = dataSet.Tables[0];

                }


            }
            catch (Exception ex)
            {
                throw ex;
            }


            return dataTable;
        }


        static List<Datacollection> dataCol = new List<Datacollection>();
        internal static object Rows;

        public static void PopulateInCollection(string fileName)
        {
            DataTable table = ExcelToDataTable(fileName);

            //Iterate through the rows and columns of the Table
            for (int row = 0; row < table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        RowNumber = row + 1,
                        ColName = table.Columns[col].ColumnName,
                        ColValue = table.Rows[row][col].ToString()
                    };
                    //Add all the details for each row
                    dataCol.Add(dtTable);
                }
            }
        }

        public static string ReadData(int rowNumber, string ColumnName)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in dataCol
                               where colData.ColName == ColumnName && colData.RowNumber == rowNumber
                               select colData.ColValue).SingleOrDefault();


                //var val = dataCol.Where(x => (x.ColName == ColumnName && x.RowNumber == rowNumber)).FirstOrDefault();
                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<Datacollection> NewPopulateInCollection(string fileName)
        {
            List<Datacollection> dataList = new List<Datacollection>();
            DataTable table = ExcelToDataTable(fileName);

            //Iterate through the rows and columns of the Table
            for (int row = 0; row < table.Rows.Count; row++)
            {
                for (int col = 0; col < table.Columns.Count; col++)
                {
                    Datacollection dtTable = new Datacollection()
                    {
                        RowNumber = row + 1,
                        ColName = table.Columns[col].ColumnName,
                        ColValue = table.Rows[row][col].ToString()
                    };
                    //Add all the details for each row
                    dataList.Add(dtTable);
                }
            }

            return dataList;
        }


        public static string ReadData(int rowNumber, string ColumnName, List<Datacollection> dataList)
        {
            try
            {
                //Retriving Data using LINQ to reduce much of iterations
                string data = (from colData in dataList
                               where colData.ColName == ColumnName && colData.RowNumber == rowNumber
                               select colData.ColValue).SingleOrDefault();


                //var val = dataCol.Where(x => (x.ColName == ColumnName && x.RowNumber == rowNumber)).FirstOrDefault();
                //var datas = dataCol.Where(x => x.colName == columnName && x.rowNumber == rowNumber).SingleOrDefault().colValue;
                return data.ToString();
            }
            catch (Exception)
            {
                return null;
            }
        }


    }






    public class Datacollection
    {
        public int RowNumber { get; set; }
        public string ColName { get; set; }
        public string ColValue { get; set; }
    }
}
