public class Program
{
    static void Main(string[] args)
    {
        Console.Write(faculty(5));
    }

    public static int faculty(int number)
    {
        if (number == 1)
            return number;
        return number * faculty(number - 1);
    }
    public static int Fibonacci(int n)
    {
        if (n <= 2)
            return 1;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

}