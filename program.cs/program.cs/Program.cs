using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program.cs
{
    class Program
    {
        static int GetInteger(string prompt)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    int x = int.Parse(input);
                    if (x > 1)
                    {
                        return x;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
            }
        }
            static void Main(string[] args)
        {
                int tries = 0;
                int max = 0;
                int maxstep = 0;
                int input = GetInteger("Please enter a number that is greater than 1.");
                int n = input;

                while (n != 1)
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = (n * 3) + 1;
                    }

                    tries++;

                    if (n > max)
                    {
                        max = n;
                        maxstep = tries;
                    }
                }

                Console.WriteLine("It took " + tries + " steps to reach " + n + " from " + input + ".");
                Console.WriteLine("The value reaches it's peak of " + max + " at step " + maxstep + ".");
                Console.ReadLine();
            }

        }
    }

