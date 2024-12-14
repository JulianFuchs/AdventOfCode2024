using Day3_MullItOver.Models;

namespace Day3_MullItOver;

public class Solver2ndStar
{
    internal static double Solve(List<Operation> allOperations)
    {
        var result = 0.0;
        bool currentlyMultiplying = true;
        
        foreach (var operation in allOperations)
        {
            switch (operation)
            {
                case DoOp doOp:
                    currentlyMultiplying = true;
                    break;
                case DontOp dontOp:
                    currentlyMultiplying = false;
                    break;
                case MulOp mulOp:
                    if (currentlyMultiplying)
                    {
                        result += mulOp.value1 * mulOp.value2;
                    }
                    break;
                
                default:
                    throw new Exception("Unknown operation");
            }
        }

        return result;
    }   
}