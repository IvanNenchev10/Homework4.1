using System;
namespace Задача4
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[50];
            int k = 0;
            for(int i=1;i<=100;i++)
            {
                if(i%2==0)
                {
                    arr[k] = i;
                    k++;
                }
                else
                {
                    continue;
                }
            }
            for(int i=0;i<50;i++)
            {
                Console.WriteLine("Element {0} is:{1}", i + 1, arr[i]);
            }
        }
    }
}
