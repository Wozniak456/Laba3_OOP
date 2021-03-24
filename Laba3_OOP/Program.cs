using System;
using Library_OOP_3;
namespace Laba3_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("input an array : ");
            string str = Console.ReadLine();
            Class1 instance = new Class1(str.ToCharArray());
            Console.WriteLine($"\nThe amount of vowels: {instance.AmountOfVowels}\n");
            for (int i = 0; i < 3; i++)
            {
                Console.Write("input an index: ");
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine(instance[index]);
            }
        }
    }
}
