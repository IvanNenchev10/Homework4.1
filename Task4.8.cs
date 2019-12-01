using System;
namespace Задача8
{
    class Program
    {
        static void Fill(int[,] matrix,int[] arr,int rows,int cols)
        {
            int p, m, n, d;
            for(int i=0;i<rows;i++)
            {
                p = (rows - 1) + i;
                m = (2 * rows) - 1;
                n = (3 * rows) - 1;
                d = (4 * rows) - 2;
                for(int j=0;j<cols;j++)
                {
                    if(i==0)
                    {
                        for(int k=0;k<rows;k++)
                        {
                            matrix[i,k] = arr[k];
                        }
                    }
                    if(i!=0 && j==rows-1)
                    {
                        matrix[i, rows - 1] = arr[p];
                    }
                    if(i==(rows-1) && j<(rows-1))
                    {
                        int helper = rows - 2;
                        if(j==0)
                        {
                            matrix[i, j + (rows - 2)] = arr[m];
                            m++;
                        }
                        else if(j!=0 && j!=(rows-2))
                        {
                            matrix[i, helper - 1] = arr[m];
                            m++;
                        }
                        else
                        {
                            matrix[i, 0] = arr[m];
                            m++;
                        }
                    }
                    if(i==(rows-2) && j==0)
                    {
                        matrix[i, j] = arr[n - 1];
                    }
                    if((rows-i)==(rows-1) && j<(rows-1))
                    {
                        matrix[i, j] = arr[n];
                        n++;
                    }
                    if((rows-i)==(rows-2) && (j!=0 && j!=(rows-1)))
                    {
                       if(j==1)
                        {
                            matrix[i, rows - 2] = arr[d];
                            d++;
                        }
                       else if(j>1 && j<i)
                        {
                            matrix[i, j] = arr[d];
                            d++;
                        }
                       else
                        {
                            matrix[i, 1] = arr[d];
                        }
                    }
                }
                
            }
        }
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
        static void Main()
        {
            int[,] matrix;
            int rows, cols;
            int[] arr;
            Console.WriteLine("Enter number of rows:");
            rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of columns:");
            cols = int.Parse(Console.ReadLine());
            arr = new int[rows * cols];
            matrix = new int[rows, cols];
            for(int i=0;i<rows*cols;i++)
            {
                arr[i] = i + 1;
            }
            Fill(matrix, arr, rows, cols);
            Print(matrix, rows, cols);
            
        }
    }
}
