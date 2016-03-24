using System;

class ForeachExample
{
    static void Main()
    {
        string[] capitals =
        {
            "Sofia",
            "Washington",
            "London",
            "Moscow"
        };
        
        foreach (string capital in capitals)
        {
            Console.WriteLine(capital);
        }
    }
}
