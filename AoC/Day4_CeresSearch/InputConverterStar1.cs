using System.Collections;
using HelperLib;

namespace Day4_CeresSearch;

public class InputConverterStar1: IInputConverter<char[][]>
{
    public char[][] ConvertInput(string[] input)
    {
        var listOfArrays = new List<char[]>();

        foreach (var line in input)
        {
            listOfArrays.Add(line.ToCharArray());
        }

        return listOfArrays.ToArray();
    }
}