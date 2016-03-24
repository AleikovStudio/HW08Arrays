using System;

class PrintingArrays
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

        for (int i = 0; i < capitals.Length; i++)
        {
            Console.WriteLine("Capital[{0}] = {1}", i, capitals[i]);
        }
    }
}
