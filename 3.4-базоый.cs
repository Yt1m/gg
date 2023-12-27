using System;

class Program
{
    static void Main(string[] args)
    {
        double start = 1.1;
        double end = 2.9; 
        double step = 0.2;

        Console.WriteLine("x\ty");
        for (double x = start; x <= end; x += step)
        {
            double y = Math.Pow(x, 3) - 6 * Math.Pow(x, 2) + 2;
            Console.WriteLine($"{x}\t{y}");
        }

        Console.ReadLine();
    }
}
