using HelperLib;

namespace Day1_HistorianHysteria.CommonHelpers
{
    internal class InputConverter : IInputConverter<Tuple<List<int>, List<int>>>
    {
        public Tuple<List<int>, List<int>> ConvertInput(string[] input)
        {
            var list1 = new List<int>();
            var list2 = new List<int>();

            foreach (var line in input)
            {
                var splitLine = line.Split(' ');
                
                list1.Add(int.Parse(splitLine[0]));
                list2.Add(int.Parse(splitLine[3]));
            }

            return new Tuple<List<int>, List<int>>(list1, list2);
        }
    }
}
