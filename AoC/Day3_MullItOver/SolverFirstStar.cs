using System.Text.RegularExpressions;

namespace Day3_MullItOver;

internal static class SolverFirstStar
{
    internal static double Solve(string[] inputLines)
    {
        var result = 0d;
        
        const string pattern = @"mul\((\d*),(\d*)\)";

        Regex regex = new Regex(pattern);
        
        foreach (var inputLine in inputLines)
        {
            var matches = regex.Matches(inputLine);

            foreach (Match match in matches)
            {;
                var value1 = match.Groups[1].Value;
                var value2 = match.Groups[2].Value;

                result += int.Parse(value1) * int.Parse(value2);
            }
        }
        
        
        return result;
    }
}