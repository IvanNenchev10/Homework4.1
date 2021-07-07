using System;
namespace Задача3
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[20];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = i + 1;
            }
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Element {0}={1}", i + 1, arr[i]);
            }
            Console.WriteLine();
            arr[9] = 0;
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Element {0}={1}", i + 1, arr[i]);
            }
        }
    }
}
