using System;
namespace Задача2
{
    class Program
    {
        static void Main()
        {
            string[] names = new string[5];
            string[] reverse = new string[5];
            int k = 0;
            for(int i=0;i<names.Length;i++)
            {
                Console.WriteLine("Enter person {0}:", i + 1);
                names[i] = Console.ReadLine();
            }
            for(int i=names.Length-1;i>=0;i--)
            {
                reverse[k] = names[i];
                k++;
            }
            for(int i=0;i<reverse.Length;i++)
            {
                Console.WriteLine("Person {0} is:{1}", i + 1, reverse[i]);
            }
            
        }
    }
}
