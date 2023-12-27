using System;

class Program
{
    static double CalculateSeriesSum(double x, int n)
    {
        double sum = 1;
        double term = 1;
        double factorial = 1;
        for (int i = 1; i <= n; i++)
        {
            term *= (2 * x) / i; 
            sum += term; 
            factorial *= i;
        }
        return sum;
    }
    static void Main(string[] args)
    {
        double x = 1.5;
        int n = 10; 

        double sum = CalculateSeriesSum(x, n);

        Console.WriteLine("Сумма первых {0} членов ряда: {1}", n, sum);
    }
}