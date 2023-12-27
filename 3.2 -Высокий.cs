using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Числа Армстронга из трех цифр:");
        FindArmstrongNumbers(3);

        Console.WriteLine("\nЧисла Армстронга из четырех цифр:");
        FindArmstrongNumbers(4);
    }

    static void FindArmstrongNumbers(int n)
    {
        for (int i = (int)Math.Pow(10, n - 1); i < Math.Pow(10, n); i++)
        {
            int number = i;
            int sum = 0;

            while (number > 0)
            {
                int digit = number % 10;
                sum += (int)Math.Pow(digit, n);
                number /= 10;
            }

            if (sum == i)
            {
                Console.WriteLine(i);
            }
        }
    }
}
