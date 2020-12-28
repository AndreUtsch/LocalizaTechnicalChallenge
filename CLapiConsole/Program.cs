using CLapiConsole.Functions;
using System;
using System.Collections.Generic;

namespace CLapiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter a number of your choice");
                var userEntry = Console.ReadLine();

                TechnicalChallenge TC = new TechnicalChallenge();
                Dictionary<String, List<int>> dDecomposeNumbers = TC.GetNumbers(userEntry);

                if (dDecomposeNumbers.Count > 0)
                {
                    foreach (KeyValuePair<String, List<int>> item in dDecomposeNumbers)
                    {
                        Console.Write("{0} =>", item.Key);

                        foreach (int number in item.Value)
                        {
                            Console.Write(" {0} ", number);
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Please, type a integer number");
                }

            } while (true);
        }
    }
}
