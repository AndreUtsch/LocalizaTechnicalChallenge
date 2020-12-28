using System;
using System.Collections.Generic;
using Xunit;
using CLapiConsole.Functions;

namespace XUnitTechnicalChallenge
{
    public class TechicalChallengeTest
    {
        [Fact]
        public void ShouldReturnAllDividersAndPrimeNumbers()
        {
            TechnicalChallenge TC = new TechnicalChallenge();
            Dictionary<String, List<int>> dNumbers = TC.GetNumbers("49");

            Dictionary<String, List<int>> teste = new Dictionary<string, List<int>>()
            {
                {"Divider", new List<int>{1,7,49}},
                {"PrimeNumber", new List<int>{1,7}}
            };

            Assert.Equal(teste, dNumbers);
        }

        [Fact]
        public void ShouldReturnAEmptyObject()
        {
            TechnicalChallenge TC = new TechnicalChallenge();
            Dictionary<String, List<int>> teste = TC.GetNumbers("04M23");

            Assert.Equal(teste, new Dictionary<String, List<int>>());
        }


    }
}
