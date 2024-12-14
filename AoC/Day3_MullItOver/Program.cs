// See https://aka.ms/new-console-template for more information

using Day3_MullItOver;
using HelperLib;

Console.WriteLine("Solving for first star *");

var input = FileInputReader.ReadInputFile();

var solution1 = SolverFirstStar.Solve(input);

Console.WriteLine($"Solution for first star *: {solution1}");

Console.WriteLine("----------------------");

Console.WriteLine("Solving for second star **");

var convertedInput = new InputConverterStar2().ConvertInput(input);

var solution2 = Solver2ndStar.Solve(convertedInput);

Console.WriteLine($"Solution for second star **: {solution2}");


