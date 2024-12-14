using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1_HistorianHysteria
{
    internal static class SolverFirstStar
    {
        public static double Solve(List<int> directions1, List<int> directions2) {
            
            directions1.Sort();
            directions2.Sort();

            double result = 0;
            var counter = 0;
            while (counter < directions1.Count) {
                result += Math.Abs(directions1[counter] - directions2[counter]);
                counter++;
            }

            return result;
        
        }
    }
}
