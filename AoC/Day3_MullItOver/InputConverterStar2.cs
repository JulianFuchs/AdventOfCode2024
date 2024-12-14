using System.Text.RegularExpressions;
using Day3_MullItOver.Models;
using HelperLib;

public class InputConverterStar2: IInputConverter<List<Operation>>
{
    public List<Operation> ConvertInput(string[] input)
    {
        var result = new List<Operation>();
        
        const string pattern = @"mul\((\d*),(\d*)\)|don't|do";

        Regex regex = new Regex(pattern);

        foreach (var inputLine in input)
        {
            var matches = regex.Matches(inputLine);

            foreach (Match match in matches)
            {
                switch (match.Value)
                {
                    case "do":
                        result.Add(new DoOp());
                        break;
                    case "don't":
                        result.Add(new DontOp());
                        break;
                    default:
                        var value1 = match.Groups[1].Value;
                        var value2 = match.Groups[2].Value;
                        result.Add(new MulOp(int.Parse(value1), int.Parse(value2)));
                        break;
                }
            }
        }

        return result;
    }
}