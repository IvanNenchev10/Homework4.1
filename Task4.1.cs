using System;
namespace Задача1
{
    class Program
    {
        static void Main()
        {
            string[] names = new string[5];
            for(int i=0;i<names.Length;i++)
            {
                Console.WriteLine("Enter name of person {0}:", i + 1);
                names[i] = Console.ReadLine();
            }
            for(int i=0;i<names.Length;i++)
            {
                Console.WriteLine("Name {0} is:{1}", i + 1, names[i]);
            }
        }
    }
}
