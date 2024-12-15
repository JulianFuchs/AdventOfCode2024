// See https://aka.ms/new-console-template for more information

using Day4_CeresSearch;
using HelperLib;

// var input = FileInputReader.ReadInputFile("testInput1.txt");

var input = FileInputReader.ReadInputFile();

var matrix = new InputConverterStar1().ConvertInput(input);

AdventLogger.WriteStarting(1);

var resultFirstStar = SolverFirstStar.GetInstance().Solve(matrix);

AdventLogger.WriteSolution(1, resultFirstStar);

AdventLogger.WriteSeparator();

AdventLogger.WriteStarting(2);


