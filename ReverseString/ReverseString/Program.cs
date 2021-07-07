using System;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s = Console.ReadLine();
            string rev = "";
            for (int i=s.Length-1;i>=0;i--)
            {
                rev = rev + s[i];
            }
            Console.WriteLine(rev);
        }
    }
}
