PrintFizzBuzz();

public static partial class Program
{
    public static readonly string Fizz = "Fizz";
    public static readonly string Buzz = "Buzz";

    public static string FizzBuzz(int input)
    {
        var output = string.Empty;

        if (input % 3 == 0)
        {
            output += Fizz;
        }

        if (input % 5 == 0)
        {
            output += Buzz;
        }

        return string.IsNullOrEmpty(output)
            ? input.ToString()
            : output;
    }

    public static void PrintFizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(FizzBuzz(i));
        }
    }
}