namespace _14.Export_to_Excel
{
    using System.Drawing;
    using System.IO;
    using OfficeOpenXml;
    using OfficeOpenXml.Style;

    //Need to have library "EPPlus"
    public class ExportToExcel
    {
        public static void Main(string[] args)
        {
            string directory = Directory.GetCurrentDirectory();
            string[] inputData = File.ReadAllLines(directory + @"\StudentData.txt");

            FileInfo newFile = new FileInfo(directory + @"\StudentData.xlsx");

            string[] excelColumns = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N" };

            using (ExcelPackage pck = new ExcelPackage(newFile))
            {
                int dataStartRow = 2;
                var ws = pck.Workbook.Worksheets.Add("Content");

                string headers = inputData[0];
                var columns = headers.Split(new char[] { '\t' });

                for (int j = 0; j < columns.Length; j++)
                {
                    string cell = excelColumns[j] + (1);
                    ws.Cells[cell].Value = columns[j];
                    ws.Cells[cell].Style.Font.Bold = true;

                    ws.Cells[cell].Style.Border.Top.Style = ExcelBorderStyle.Medium;
                    ws.Cells[cell].Style.Border.Left.Style = ExcelBorderStyle.Medium;
                    ws.Cells[cell].Style.Border.Right.Style = ExcelBorderStyle.Medium;
                    ws.Cells[cell].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                    ws.Cells[cell].Style.Fill.PatternType = ExcelFillStyle.Solid;
                    ws.Cells[cell].Style.Fill.BackgroundColor.SetColor(Color.GreenYellow);
                }

                for (int i = 1; i < inputData.Length; i++)
                {
                    columns = inputData[i].Split(new char[] { '\t' });

                    for (int j = 0; j < columns.Length; j++)
                    {
                        string cell = excelColumns[j] + (i + 1);
                        ws.Cells[cell].Value = columns[j];
                    }

                }

                pck.Save();
            }
        }
    }
}
