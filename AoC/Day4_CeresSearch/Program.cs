// See https://aka.ms/new-console-template for more information

using Day4_CeresSearch;
using HelperLib;

Console.WriteLine("Solving for first star *");

// var input = FileInputReader.ReadInputFile("testInput1.txt");

var input = FileInputReader.ReadInputFile();

var matrix = new InputConverterStar1().ConvertInput(input);

var resultFirstStar = SolverFirstStar.GetInstance().Solve(matrix);

Console.WriteLine($"Solution for first star *: {resultFirstStar}");