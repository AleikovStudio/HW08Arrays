using System;

class InputArray
{
    static void Main()
    {
        int[] arr = new int[5];
        arr[2] = 17;
        
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
    }
}
