namespace Day4_CeresSearch;

public class Solver
{
    private char[][] _matrix;
    private readonly int _rowMax = 0;
    private readonly int _columnMax = 0;

    private Solver(char[][] matrix)
    {
        _matrix = matrix;
        _rowMax = _matrix.Length;
        _columnMax = _matrix[0].Length;
    }

    public static Solver GetInstance(char[][] matrix)
    {
        return new Solver(matrix);
    }
    public int SolveFirstStar()
    {
        var result = 0;

        for (int row = 0; row < _rowMax; row++)
        {
            for (int column = 0; column < _columnMax; column++)
            {
                if (_matrix[row][column] == 'X')
                {
                    result += FindAllXmasStartingFromX(row, column);
                }
            }
        }

        return result;
    }
    
    public int SolveSecondStar()
    {
        var result = 0;

        for (int row = 0; row < _rowMax; row++)
        {
            for (int column = 0; column < _columnMax; column++)
            {
                if(_matrix[row][column] == 'A')
                {
                    if (IsAFormingAnX(row, column))
                    {
                        result++;
                    }
                }
            }
        }

        return result;
    }

    private bool IsAFormingAnX(int row, int column)
    {
        // check to see if is in bound to form an X
        if (row - 1 >= 0 && row + 1 < _rowMax && column - 1 >= 0 && column + 1 < _columnMax)
        {
            if ((_matrix[row - 1][column - 1] == 'M' && _matrix[row + 1][column + 1] == 'S')
                || (_matrix[row - 1][column - 1] == 'S' && _matrix[row + 1][column + 1] == 'M'))
            {
                if ((_matrix[row + 1][column - 1] == 'M' && _matrix[row - 1][column + 1] == 'S')
                    || (_matrix[row + 1][column - 1] == 'S' && _matrix[row - 1][column + 1] == 'M'))
                {
                    return true;
                }
            } 
        }

        return false;
    }

    private int FindAllXmasStartingFromX(int row, int column)
    {
        var xmasesStartingWithThisX = 0;
        
        // the samx going north-west
        if (column - 3 >= 0 && row - 3 >= 0)
        {
            if (_matrix[row - 1][column - 1] == 'M' && _matrix[row - 2][column - 2] == 'A' && _matrix[row - 3][column - 3] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the samx going north
        if (row - 3 >= 0)
        {
            if (_matrix[row - 1][column] == 'M' && _matrix[row - 2][column] == 'A' && _matrix[row - 3][column] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the xmas going north-east
        if (row - 3 >= 0 && column + 3 < _columnMax)
        {
            if (_matrix[row - 1][column + 1] == 'M' && _matrix[row - 2][column + 2] == 'A' && _matrix[row - 3][column + 3] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the xmas going east
        if (column + 3 < _columnMax)
        {
            if (_matrix[row][column + 1] == 'M' && _matrix[row][column + 2] == 'A' && _matrix[row][column + 3] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the xmas going south-east 
        if (row + 3 < _rowMax && column + 3 < _columnMax)
        {
            if (_matrix[row + 1][column + 1] == 'M' && _matrix[row + 2][column + 2] == 'A' && _matrix[row + 3][column + 3] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the xmas going south
        if (row + 3 < _rowMax)
        {
            if (_matrix[row + 1][column] == 'M' && _matrix[row + 2][column] == 'A' && _matrix[row + 3][column] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the xmas going south-west
        if (row + 3 < _rowMax && column - 3 >= 0)
        {
            if (_matrix[row + 1][column - 1] == 'M' && _matrix[row + 2][column - 2] == 'A' && _matrix[row + 3][column - 3] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // the xmax going west
        if (column - 3 >= 0)
        {
            if (_matrix[row][column - 1] == 'M' && _matrix[row][column - 2] == 'A' && _matrix[row][column - 3] == 'S')
            {
                xmasesStartingWithThisX++;
            }
        }
        
        // Console.WriteLine($"For X at row: {row}, column: {column}, found {xmasesStartingWithThisX} Xmases");
        
        return xmasesStartingWithThisX;
    }
}