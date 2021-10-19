using DOWS_SmokeTest.com.DOWS.Utils;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOWS_SmokeTest
{
    class TestPracticeClass
    {
        [Test]
        public void One()
        {
            WriteExcelNew enew = new WriteExcelNew();
            var excelPath = @ConfigurationManager.AppSettings["ExcelData"];


            // enew.OpenExcel(one);
            //   enew.getShee
            enew.Write(excelPath, "One", 15, "Pass");



        }
    }
}
