// See https://aka.ms/new-console-template for more information

using Day1_HistorianHysteria.CommonHelpers;
using Day3_MullItOver;

Console.WriteLine("Solving for first star *");

var input = FileInputReader.ReadInputFile();

var solution1 = SolverFirstStar.Solve(input);

Console.WriteLine($"Solution for first star *: {solution1}");

