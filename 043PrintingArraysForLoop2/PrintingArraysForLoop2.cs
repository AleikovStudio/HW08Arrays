using System;

class PrintingArraysForLoop2
{
    static void Main()
    {
        Console.WriteLine("Enter how long your array will be: ");
        int size = int.Parse(Console.ReadLine());
        int[] arr = new int[size];

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine("Enter your number: ");
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Values of the Array: ");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}



