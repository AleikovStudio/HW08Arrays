using System;

class ReversedArray
{
    static void Main()
    {
        {
            var array = new int[] { 1, 2, 3, 4, 5 };

            //Get array size
            var length = array.Length;

            //Declare and create the reversed array
            int[] reversed = new int[length];

            //Initialize the reveresed array
            for (var index = 0; index < length; index++)
            {
                reversed[length - index - 1] = array[index];
            }

            //Print the reversed array elements
            for (var index = 0; index < length; index++)
            {
                Console.WriteLine(reversed[index]);
            }
        }
    }
}
