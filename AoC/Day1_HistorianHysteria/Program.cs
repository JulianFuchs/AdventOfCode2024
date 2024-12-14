using Day1_HistorianHysteria;
using Day1_HistorianHysteria.CommonHelpers;
using HelperLib;

Console.WriteLine("Hello, World!");

var input = FileInputReader.ReadInputFile();

var inputConverter = new InputConverter();

var convertedInput = inputConverter.ConvertInput(input);


var locationList1 = convertedInput.Item1;
var locationList2 = convertedInput.Item2;

locationList1.Sort();
locationList2.Sort();

var result = SolverFirstStar.Solve(locationList1, locationList2);

Console.WriteLine($"Result is: {result}");

