namespace Day1_HistorianHysteria.CommonHelpers
{
    public static class FileInputReader
    {
        public static string[] ReadInputFile()
        {
            var filePath = "input.txt";

            string[] lines = File.ReadAllLines(filePath);
            
            return lines;
        }

    }
}
