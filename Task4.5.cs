using System;

namespace Задача5
{
    class Program
    {
        static void Main()
        {
            int[] arr = new int[10];
            int[] arr1 = new int[10];
            int[] array = new int[10];
            int counter = 0;
            bool result = false;
            for(int i=0;i<arr.Length;i++)
            {
                Console.WriteLine("Enter element {0} for the first array:", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            foreach(int i in arr)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();
            for(int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine("Enter element {0} for the second array:", i + 1);
                arr1[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            foreach(int i in arr1)
            {
                Console.Write("{0} ", i);
            }
            for(int i=0;i<arr.Length;i++)
            {
                for(int j=0;j<arr1.Length;j++)
                {
                    if(arr[i]==arr1[j])
                    {
                        array[counter] = arr[i];
                        counter++;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Common elements:");
            int k = 0;
            while(k<counter)
            {
                result = false;
                for(int j=k+1;j<counter;j++)
                {
                    if(array[k]==array[j])
                    {
                        for(int i=k;i<counter;i++)
                        {
                            array[i] = array[i + 1];
                        }
                        result = true;
                        counter--;
                        break;
                    }
                }
                if(result==false)
                {
                    k++;
                }
            }
            for(int i=0;i<counter;i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
    }
}
