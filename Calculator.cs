class Calculator
{
    private int numberOne;
    private int numberTwo;

    public Calculator(int num1, int num2)
    {
        this.numberOne = num1;
        this.numberTwo = num2;
    }
    public int add()
    {
        return this.numberOne + this.numberTwo;
    }
    public int subtract()
    {
        return this.numberOne - this.numberTwo;
    }
    public int multiply()
    {
        int result = 0;
        for (int i = 0; i < this.numberTwo; i++)
        {
            result += numberOne;
        }
        return result;
    }
    public double divide()
    {
        if (this.numberTwo == 0)
        {
            Console.WriteLine("Division by zero is not allowed.");
            return 0;
        }

        int dividend = numberOne;
        int divisor = numberTwo;

        int sign = (dividend < 0) ^ (divisor < 0) ? -1 : 1;

        dividend = Math.Abs(dividend);
        divisor = Math.Abs(divisor);

        int integerQuotient = 0;

        while (dividend >= divisor)
        {
            dividend -= divisor;
            integerQuotient++;
        }

        double decimalPart = (double)dividend / divisor;

        return integerQuotient * sign + decimalPart;
    }
}
