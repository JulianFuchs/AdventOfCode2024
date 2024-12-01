using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_HistorianHysteria.CommonHelpers
{
    internal static class FileInputReader
    {
        public static string[] ReadInputFile()
        {
            var filePath = "input.txt";

            string[] lines = File.ReadAllLines(filePath);



            return lines;
        }

    }
}
