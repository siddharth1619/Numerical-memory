using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using System.Data.Common;
using System.Security.Cryptography.X509Certificates;

namespace Cognisess_numerical_memory
{
    public class Test
    {
        private static readonly Random random = new Random(20);

        public static List<int> GenerateRandom(int count)
        {
            // generate count random values.
            HashSet<int> candidates = new HashSet<int>();
            // HashSet<int> score = new HashSet<int>();

            int length = 100;
            while (candidates.Count < count)
            {
                // May strike a duplicate.
                candidates.Add(random.Next(length / 10, length));
                while (length < 1000000000)
                    length = length * 10;

            }

            // load them in to a list.
            List<int> result = new List<int>();

            result.AddRange(candidates);

            // shuffle the results:
            int i = result.Count;

            {
                int score = 0;
                while (i > 0)
                {
                    {
                        i--;
                        Console.WriteLine("Type any number:  "); // or Console.Write("Type any number:  "); to enter number in the same line
                        int a = int.Parse(Console.ReadLine());
                        int can = candidates.ElementAt(i);
                        Console.WriteLine("i : " + i);
                        if (a == can)
                        {
                            score = score + 10;
                            Console.WriteLine("Answer is Correct and your Score is :" + score);
                        }
                        else
                        {
                            Console.WriteLine("Answer is Incorrect and your Score is :" + score);
                        }

                    }

                }
                Console.WriteLine("Summary is: " + score);

                return result;
            }


        }
        public static void Main()
        {
            List<int> vals = GenerateRandom(20);
            Console.WriteLine("Result: " + vals.Count);
            vals.ForEach(Console.WriteLine);
        }
    }
}
