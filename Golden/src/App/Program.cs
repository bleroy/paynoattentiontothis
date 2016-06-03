using System;
using Library;

namespace App
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"The answer is {new Thing().Get(42)}");
        }
    }
}
