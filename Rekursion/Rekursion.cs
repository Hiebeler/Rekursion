public class Rekursion
{
    static void Main(string[] args)
    {
    }

    public static int Faculty(int number)
    {
        if (number == 1)
            return number;
        return number * Faculty(number - 1);
    }

    public static int Fibonacci(int number)
    {
        if (number <= 2)
            return 1;
        return Fibonacci(number - 1) + Fibonacci(number - 2);
    }

}