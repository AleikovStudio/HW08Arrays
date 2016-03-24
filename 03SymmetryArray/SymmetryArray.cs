using System;

class SymmetryArray
{
    static void Main()
    {
        Console.Write("Enter how many elements will be in the array: ");
        int size = int.Parse(Console.ReadLine());
        
        // Declaring the array
        int[] array = new int[size];
        
        // Filling the array
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("arr[{0}] = ", i);
            array[i] = int.Parse(Console.ReadLine());
        }
        bool isSymmetric = true;
        for (int i = 0; i < (array.Length / 2); i++)
        {
            if (array[i] != array[size - i - 1])
            {
                isSymmetric = false;
                break;
            }
        }
        Console.WriteLine("Symmetric?? --> {0}", isSymmetric);
    }
}
