using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollatzRandom
{
    class Collatz
    {
        static Random rand = new Random();

        static void Main()
        {
            int n = rand.Next(1, 1001);
            GenerateSequence(n);
            Console.ReadKey();
        }

        static void GenerateSequence(int n)
        {
            if (n < 1) throw new ArgumentException("Must be a positive integer");

            int max = n;
            int count = 1;
            Console.Clear();
            Console.WriteLine("{0} (starting number in Collatz sequence)", n);

            while (n > 1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = 3 * n + 1;
                }

                count++;
                if (n > max) max = n;
                Console.WriteLine(n);
            }

            Console.WriteLine("\nThere are {0} items(s) in the sequence", count);
            Console.WriteLine("The largest number in the sequence is {0}", max);
        }
    }
}

