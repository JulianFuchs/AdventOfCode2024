namespace Day3_MullItOver.Models;

public class MulOp: Operation
{
    public int value1 { get; private set; }
    public int value2 { get; private set; }

    public MulOp(int value1, int value2)
    {
        this.value1 = value1;
        this.value2 = value2;
    }
}