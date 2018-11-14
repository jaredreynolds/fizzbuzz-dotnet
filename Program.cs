using System;
using System.Linq;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in Enumerable.Range(1, 100))
            {
                bool fizzbuzzed = false;

                if (i % 3 == 0) {
                    Console.Write("Fizz");
                    fizzbuzzed = true;
                }

                if (i % 5 == 0) {
                    Console.Write("Buzz");
                    fizzbuzzed = true;
                }

                if (!fizzbuzzed)
                {
                    Console.Write(i);
                }

                Console.WriteLine();
            }
        }
    }
}
