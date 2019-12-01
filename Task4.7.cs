using System;
namespace Задача7
{
    class Program
    {
        static void Print(int[,]matrix ,int rows,int cols)
        {
            for (int i = 0; i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void Result(int[,] matrix,int rows,int cols)
        {
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    Console.Write("{0} ", matrix[j, i]);
                }
                Console.WriteLine();
            }
        }
        static void Main()
        {
            int[,] matrix;
            int rows, cols;
            Console.WriteLine("Enter number of rows:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns:");
            cols = int.Parse(Console.ReadLine());
            matrix = new int[rows, cols];
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    Console.WriteLine("Enter element [{0},{1}]:", i + 1, j + 1);
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Print(matrix, rows, cols);
            Console.WriteLine();
            Result(matrix, rows, cols);
        }
    }
}
