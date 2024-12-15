// See https://aka.ms/new-console-template for more information

using Day3_MullItOver;
using HelperLib;

AdventLogger.WriteStarting(1);

var input = FileInputReader.ReadInputFile();

var solution1 = SolverFirstStar.Solve(input);

AdventLogger.WriteSolution(1, solution1);

AdventLogger.WriteSeparator();

AdventLogger.WriteStarting(2);

var convertedInput = new InputConverterStar2().ConvertInput(input);

var solution2 = Solver2ndStar.Solve(convertedInput);

AdventLogger.WriteSolution(2, solution2);


