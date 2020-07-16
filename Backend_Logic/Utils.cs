using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using iText;
using iText.IO.Font.Constants;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;

namespace Backend_Logic
{
    // The Utils class is a static class with helper functions useful to database operations and data manipulation
    public static class Utils
    {
        //Hashing function to translate a string into it's SHA1 hash
        public static string GetSha1(String input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var result = new StringBuilder(hash.Length * 2);

                foreach (var by in hash)
                {
                    result.Append(by.ToString("x2"));
                }

                return result.ToString().ToUpper();
            }
        }

        // static method used to turn a list into a datatable. This is used when generating reports.
        public static DataTable ListtoDataTable<T>(List<T> items)
        {
            DataTable result = new DataTable(typeof(T).Name);

            // The lists will be either of type client or of type finance. We will use those objects properties as
            // columns for the datatable
            PropertyInfo[] properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);
            var headers = new object[properties.Length];
            var h = 0;
            foreach (PropertyInfo property in properties)
            {
                result.Columns.Add(property.Name);
                headers[h] = property.Name;
                h++;
            }
            result.Rows.Add(headers);

            // For each item in the list, we simple grab each value and add it under the appropriate column
            foreach (T item in items)
            {
                var values = new object[properties.Length];
                for (int i=0;i<properties.Length; i++)
                {
                    values[i] = properties[i].GetValue(item, null);
                }
                result.Rows.Add(values);
            }

            return result;
        }

        public static void GeneratePDF(string filename, DataTable dataTable, string reportTitle = "MC2 Report")
        {
            
            PdfWriter writer = new PdfWriter(filename);
            PdfDocument Test = new PdfDocument(writer);

            using (Document document = new Document(Test))
            {
                document.SetTextAlignment(TextAlignment.CENTER);


                Text title = new Text(reportTitle + "\n").SetFont(PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN,true)).SetFontSize(18);
                Text timestamp = new Text("Generated: " + DateTime.Now + "\n\n").SetFont(PdfFontFactory.CreateFont(StandardFonts.TIMES_ROMAN,true)).SetFontSize(10);
                document.Add(new Paragraph().Add(title).Add(timestamp));
                
                Table table = new Table(UnitValue.CreatePercentArray(dataTable.Columns.Count)).UseAllAvailableWidth();

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (DataColumn column in dataTable.Columns)
                    {
                        Cell cell = new Cell().Add(new Paragraph(row[column].ToString()));
                        cell.SetTextAlignment(TextAlignment.CENTER);

                        // If it is the first row (header) set to white text on black background
                        // Alternate the remaining rows background color to make reading reports easier.
                        if (row == dataTable.Rows[0] )
                        {
                            cell.SetFontColor(ColorConstants.WHITE);
                            cell.SetBackgroundColor(ColorConstants.BLACK);
                        }
                        else if (table.GetNumberOfRows()%2 == 0 || (table.GetNumberOfRows() % 2 != 0 && column == dataTable.Columns[0]))
                        {
                            cell.SetFontColor(ColorConstants.BLACK);
                            cell.SetBackgroundColor(ColorConstants.WHITE);
                        }
                        else if (table.GetNumberOfRows() % 2 == 1 || (table.GetNumberOfRows() % 2 != 1 && column == dataTable.Columns[0]))
                        {
                            cell.SetFontColor(ColorConstants.BLACK);
                            cell.SetBackgroundColor(ColorConstants.LIGHT_GRAY);
                        }

                        table.AddCell(cell);
                    }  
                }

                document.Add(table);
            }    

        }
    }
}
