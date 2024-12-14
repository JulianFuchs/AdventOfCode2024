namespace HelperLib
{
    public static class FileInputReader
    {
        public static string[] ReadInputFile(string filename = "input.txt")
        {
            string[] lines = File.ReadAllLines(filename);
            
            return lines;
        }

    }
}
