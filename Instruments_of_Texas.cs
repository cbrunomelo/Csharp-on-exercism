public class CalculationException : Exception
{
    public CalculationException(int operand1, int operand2, string message, Exception inner) : base(message, inner)
    {
        Operand1 = operand1;
        Operand2 = operand2;
    }
    public int Operand1 { get; }
    public int Operand2 { get; }
}
public class CalculatorTestHarness
{
    private Calculator calculator;
    public CalculatorTestHarness(Calculator calculator)
    {
        this.calculator = calculator;
    }
    public string TestMultiplication(int x, int y)
    {
        try
        {
            Multiply(x, y);
        }
        catch (CalculationException ce)
        {
            if (x < 0 && y < 0)
                return $"Multiply failed for negative operands. {ce.Message}";
            return $"Multiply failed for mixed or positive operands. {ce.Message}";
        }
        return "Multiply succeeded";
    }
    public void Multiply(int x, int y)
    {
        try
        {
            calculator.Multiply(x, y);
        }
        catch (OverflowException oe)
        {
            throw new CalculationException(x, y, oe.Message, oe.InnerException);
        }
    }
}

//check overflow
public class Calculator
{
    public int Multiply(int x, int y)
    {
        checked
        {
            return x * y;
        }
    }
}