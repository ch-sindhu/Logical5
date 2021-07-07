using System;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
         int row, i, j, k;
        Console.Write("Enter the no. of row you want to print: ");
        row = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= row; i++)
            {
                k = 1;
                for (j = i; j <= row - 1; j++)
                    Console.Write(" ");

                for (j = 0; j <= i; j++)
                {
                    Console.Write("{0} ", k);
                    k = (k * (i - j) / (j + 1));
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
