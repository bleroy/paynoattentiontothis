using System;
using Library;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"The answer to everything is: {new Thing().Get(42)}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}
