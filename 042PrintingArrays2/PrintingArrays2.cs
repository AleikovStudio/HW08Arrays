using System;

class PrintingArrays2
{
    static void Main()
    {
        Console.WriteLine("Enter how long would you like your array to be:");
        int size = int.Parse(Console.ReadLine()); //opredelya se ot potrebitelya kolko elementa shte ima v masiva
        int[] arr = new int[size]; //tova e deklaraciya na nov masiv s broi elementi opredeleni ot gorniya red

        for (int i = 0; i < size; i++) //for loop za da se napishat ot potrebitelya koi chisla shte sa vatre v masiva
        {
            Console.Write("Enter your integer: ");
            arr[i] = int.Parse(Console.ReadLine());  //potrebitelyat vavejda vsyako edno ot chislata spored "i"
        }
        Console.WriteLine(string.Join(", ", arr)); //method za svarzvane na stringove = string.Join
    }
}



