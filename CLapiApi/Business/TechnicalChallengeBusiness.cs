using System;
using System.Collections.Generic;
using System.Text;
using CLapiConsole.Functions;

namespace ClapiApi.Business
{
    public class TechnicalChallengeBusiness
    {
        /// <summary>
        /// This method call the Clapi to decompose the number
        /// </summary>
        /// <param name="pNumber">The number chosen by the user</param>
        /// <returns></returns>
        public String GetNumbers(string pNumber)
        {
            StringBuilder result = new StringBuilder();
            TechnicalChallenge TC = new TechnicalChallenge();
            Dictionary<String, List<int>> dDecomposeNumbers = TC.GetNumbers(pNumber);

            if (dDecomposeNumbers.Count > 0)
            {
                foreach (KeyValuePair<String, List<int>> item in dDecomposeNumbers)
                {
                    result.Append(String.Format("{0} => ", item.Key));

                    foreach (int number in item.Value)
                    {
                        result.Append(String.Format(" {0} ", number));
                    }

                    result.AppendLine();
                }
            }
            else
            {
                result.AppendLine("Not a valid number");
            }

            return result.ToString();
        }
    }
}
