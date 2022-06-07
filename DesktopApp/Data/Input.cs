using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopApp.Data
{
    public class Input
    {
        public static async Task<List<string>> Read()
        {
            List<String[]> fileContent = new List<string[]>();

            using (FileStream reader = File.OpenRead(@"listing_status.csv")) // mind the encoding - UTF8
            using (TextFieldParser parser = new TextFieldParser(reader))
            {
                parser.TrimWhiteSpace = true; // if you want
                parser.Delimiters = new[] { "," };
                parser.HasFieldsEnclosedInQuotes = true;
                while (!parser.EndOfData)
                {
                    string[] line = parser.ReadFields();
                    fileContent.Add(line);
                }
            }
            return fileContent.Select(line => line[0] + " - " + line[1]).ToList();
        }
    }
}