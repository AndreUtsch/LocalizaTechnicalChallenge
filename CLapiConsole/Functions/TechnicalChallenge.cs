using System;
using System.Collections.Generic;
using System.Text;

namespace CLapiConsole.Functions
{
    /// <summary>
    /// Class responsible to decompose a number in all their dividers, also enumerating those that are prime
    /// </summary>
    public class TechnicalChallenge
    {
        private const String divisor = "Divisor";
        private const String primeNumber = "PrimeNumber";

        /// <summary>
        /// Returns the Dictionary with the decomposed number
        /// </summary>
        /// <returns></returns>
        public Dictionary<String, List<int>> GetNumbers(string pNumber)
        {
            if (!int.TryParse(pNumber, out int result))
                return new Dictionary<string, List<int>>();
            else
                return DecomposeNumber(result);
        }

        /// <summary>
        /// Method responsible for decompose de the number 
        /// </summary>
        /// <param name="pNumber">The number select by the user</param>
        /// <returns></returns>
        private Dictionary<string, List<int>> DecomposeNumber(int pNumber)
        {
            Dictionary<String, List<int>> dDecomposeNumbers = new Dictionary<String, List<int>>();
            List<int> divisors = new List<int>();
            List<int> primeNumbers = new List<int>();

            for (int divisor = 1; divisor <= pNumber; divisor++)
            {
                Math.DivRem(pNumber, divisor, out int result);

                if (result == 0)
                {
                    divisors.Add(divisor);

                    if (IsPrimeNumber(divisor))
                    {
                        primeNumbers.Add(divisor);
                    }
                }
            }

            dDecomposeNumbers.Add(divisor, divisors);
            dDecomposeNumbers.Add(primeNumber, primeNumbers);

            return dDecomposeNumbers;
        }

        /// <summary>
        /// Returns whether the divisor is a prime number or not
        /// </summary>
        /// <param name="pNumber">The divider of the number selected by the user</param>
        /// <returns></returns>
        private Boolean IsPrimeNumber(int pNumber)
        {
            int factor = pNumber / 2;

            for (int i = 2; i <= factor; i++)
            {
                if ((pNumber % i) == 0)
                {
                    return false;
                }

            }
            return true;
        }

    }
}

