ProgramT.PrintFizzBuzz();

public static class ProgramT
{
    public static string FizzBuzz(int input)
    {
        var output = string.Empty;

        if (input % 3 == 0)
        {
            output += "Fizz";
        }

        if (input % 5 == 0)
        {
            output += "Buzz";
        }

        var result = string.IsNullOrEmpty(output)
            ? input.ToString()
            : output;

        //Console.WriteLine(result)
        return result;
    }

    public static void PrintFizzBuzz()
    {
        for (int i = 1; i <= 100; i++)
        {
            Console.WriteLine(FizzBuzz(i));
        }
    }
}