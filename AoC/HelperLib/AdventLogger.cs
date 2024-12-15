namespace HelperLib;

public static class AdventLogger
{
    public static void WriteSeparator()
    {
        Console.WriteLine("---------------------");
    }
    
    public static void WriteStarting(int star)
    {
        var stars = findStars(star);
        Console.WriteLine($"Starting to find solution for {stars} problem");
    }
    
    public static void WriteSolution<T>(int star, T solution)
    {
        var stars = findStars(star);
        Console.WriteLine($"Solution for {stars} problem is: {solution}");
    }

    private static string findStars(int star)
    {
        return (star == 1) ? "*" : "**";
    }
}