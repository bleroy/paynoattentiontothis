using System;
using PCLLibrary;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"The answer is {new Thing().Get(42)}");
        }
    }
}
