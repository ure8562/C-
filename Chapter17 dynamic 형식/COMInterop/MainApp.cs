using System;
using Excel = Microsoft.Office.Interop.Excel;

namespace COMInterop
{
    class MainApp
    {
        public static void OldWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();

            excelApp.Workbooks.Add(Type.Missing);

            Excel.Worksheet worksheet = (Excel.Worksheet)excelApp.ActiveSheet;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                ((Excel.Range)worksheet.Cells[i + 1, 1]).Value2 = data[i, 0];
                ((Excel.Range)worksheet.Cells[i + 1, 2]).Value2 = data[i, 1];
            }

            worksheet.SaveAs(savePath + "\\shpark-book-old.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing,
                Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            excelApp.Quit();
        }

        public static void NewWay(string[,] data, string savePath)
        {
            Excel.Application excelApp = new Excel.Application();

            excelApp.Workbooks.Add();

            Excel._Worksheet workSheet = (Excel._Worksheet)excelApp.ActiveSheet;

            for (int i = 0; i < data.GetLength(0); i++)
            {
                workSheet.Cells[i + 1, 1] = data[i, 0];
                workSheet.Cells[i + 1, 2] = data[i, 1];
            }

            workSheet.SaveAs(savePath + "\\shpark-book-dynamic.xlsx");
            excelApp.Quit();
        }
        static void Main(string[] args)
        {
            string savePath = System.IO.Directory.GetCurrentDirectory();
            string[,] array = new string[,]
            {
                {"뇌를 자극하는 알고리즘", "2009" },
                {"뇌를 자극하는 C# 4.0", "2011" },
                {"뇌를 자극하는 C# 5.0", "2013" },
                {"뇌를 자극하는 파이썬 3", "2016" },
                {"그로킹 딥러닝", "2019" },
                {"이것이 C#이다", "2018" },
                {"이것이 C#이다 2E", "2020" }
            };

            Console.WriteLine("Creating Excel document in old way...");
            OldWay(array, savePath);

            Console.WriteLine("Creating Excel document in new way...");
            NewWay(array, savePath);
        }
    }
}
