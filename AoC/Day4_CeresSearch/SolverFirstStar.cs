namespace Day4_CeresSearch;

public class SolverFirstStar
{

    private int rowMax = 0;
    private int columnMax = 0;

    private SolverFirstStar()
    {
        
    }

    public static SolverFirstStar GetInstance()
    {
        return new SolverFirstStar();
    }
    public int Solve(char[][] matrix)
    {
        rowMax = matrix.Length;
        columnMax = matrix[0].Length;
        
        var result = 0;

        for (int row = 0; row < rowMax; row++)
        {
            for (int column = 0; column < columnMax; column++)
            {
                if (matrix[row][column] == 'X')
                {
                    result += FindAllXmasStartingFromX(matrix, row, column);
                }
            }
        }

        return result;
    }

    public int FindAllXmasStartingFromX(char[][] matrix, int row, int column)
    {
        var xmasesStartingWithThisX = 0;
        
        // the samx going north-west
        if (column - 3 >= 0 && row - 3 >= 0)
        {
            if (matrix[row - 1][column - 1] == 'M' && matrix[row - 2][column - 2] == 'A' && matrix[row - 3][column - 3] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the samx going north
        if (row - 3 >= 0)
        {
            if (matrix[row - 1][column] == 'M' && matrix[row - 2][column] == 'A' && matrix[row - 3][column] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the xmas going north-east
        if (row - 3 >= 0 && column + 3 < columnMax)
        {
            if (matrix[row - 1][column + 1] == 'M' && matrix[row - 2][column + 2] == 'A' && matrix[row - 3][column + 3] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the xmas going east
        if (column + 3 < columnMax)
        {
            if (matrix[row][column + 1] == 'M' && matrix[row][column + 2] == 'A' && matrix[row][column + 3] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the xmas going south-east 
        if (row + 3 < rowMax && column + 3 < columnMax)
        {
            if (matrix[row + 1][column + 1] == 'M' && matrix[row + 2][column + 2] == 'A' && matrix[row + 3][column + 3] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the xmas going south
        if (row + 3 < rowMax)
        {
            if (matrix[row + 1][column] == 'M' && matrix[row + 2][column] == 'A' && matrix[row + 3][column] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the xmas going south-west
        if (row + 3 < rowMax && column - 3 >= 0)
        {
            if (matrix[row + 1][column - 1] == 'M' && matrix[row + 2][column - 2] == 'A' && matrix[row + 3][column - 3] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the xmax going west
        if (column - 3 >= 0)
        {
            if (matrix[row][column - 1] == 'M' && matrix[row][column - 2] == 'A' && matrix[row][column - 3] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // Console.WriteLine($"For X at row: {row}, column: {column}, found {xmasesStartingWithThisX} Xmases");
        
        return xmasesStartingWithThisX;
    }
}