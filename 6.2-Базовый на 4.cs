using MatrixLibrary;
using System;

namespace MatrixLibrary
{
    public class MatrixOperations
    {
        public static int CalculateSumInRange(int[,] matrix, int n, int m)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int element = matrix[i, j];
                    if (element >= -2 && element <= 3)
                    {
                        sum += element;
                    }
                }
            }
            return sum;
        }
    }
}
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк матрицы:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите количество столбцов матрицы:");
            int m = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, m];

            Console.WriteLine($"Введите элементы матрицы {n}x{m}:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            int sum = MatrixOperations.CalculateSumInRange(matrix, n, m);
            Console.WriteLine($"Сумма элементов матрицы, находящихся в интервале [-2;3]: {sum}");

            Console.ReadLine();
        }
    }
}
