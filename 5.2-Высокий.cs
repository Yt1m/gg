using System;
using System.Text;

namespace ReplaceStars
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "abc*def*ghi*jkl*";
            StringBuilder result = new StringBuilder(input);

            int count = 1;
            int index = 0;
            while ((index = result.ToString().IndexOf("*", index)) != -1)
            {
                result.Replace("*", count.ToString(), index, 1);
                count++;
                index++;
            }

            Console.WriteLine(result.ToString());
        }
    }
}