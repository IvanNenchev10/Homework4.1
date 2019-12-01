using System;

namespace Задача6
{
    class Program
    {
        static void Print(int[,] matrix,int rows,int cols)
        {
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }
        static void MaxMinByRows(int[,] matrix,int rows,int cols)
        {
            int max, min;
            for(int i=0;i<rows;i++)
            {
                max = matrix[i, 0];
                min = matrix[i, 0];
                for(int j=0;j<cols;j++)
                {
                    if(max<matrix[i,j])
                    {
                        max = matrix[i, j];
                    }
                    if(min>matrix[i,j])
                    {
                        min = matrix[i, j];
                    }
                }
                Console.WriteLine("Maximum element at row {0} is:{1}", i + 1, max);
                Console.WriteLine("Minimum element at row {0} is:{1}", i + 1, min);
                Console.WriteLine();
            }
        }
        static void MaxMinByCols(int[,] matrix,int rows,int cols)
        {
            int max, min;
            for(int i=0;i<rows;i++)
            {
                max = matrix[0, i];
                min = matrix[0, i];
                for(int j=0;j<cols;j++)
                {
                    if(max<matrix[j,i])
                    {
                        max = matrix[j, i];
                    }
                    if(min>matrix[j,i])
                    {
                        min = matrix[j, i];
                    }
                }
                Console.WriteLine("Maximum element at column {0} is: {1}", i + 1, max);
                Console.WriteLine("Minimum element at column {0} is: {1}", i + 1, min);
                Console.WriteLine();
            }
        }
        static void MaxMin(int[,] matrix,int rows,int cols)
        {
            int max = matrix[0, 0];
            int min = matrix[0, 0];
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    if(max<matrix[i,j])
                    {
                        max = matrix[i, j];
                    }
                    if(min>matrix[i,j])
                    {
                        min = matrix[i, j];
                    }
                }
            }
            Console.WriteLine("Maximum element in the matrix is:{0}", max);
            Console.WriteLine("Minimum element in the matrix is:{0}", min);
        }
        static void Main()
        {
            int[,] matrix;
            int rows, cols;
            Console.WriteLine("Enter number of rows:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns:");
            cols= int.Parse(Console.ReadLine());
            matrix = new int[rows, cols];
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<cols;j++)
                {
                    Console.WriteLine("Enter element [{0},{1}]:", i + 1, j + 1);
                    matrix[i,j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine();
            Print(matrix, rows, cols);
            Console.WriteLine();
            MaxMinByRows(matrix, rows, cols);
            Console.WriteLine();
            MaxMinByCols(matrix, rows, cols);
            Console.WriteLine();
            MaxMin(matrix, rows, cols);
        }
    }
}
