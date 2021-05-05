using System;
using System.Linq;
using PixSmith.BenFordsLaw.CSharp.Domain;
using PixSmith.BenFordsLaw.CSharp.Services.Interfaces;

namespace PixSmith.BenFordsLaw.CSharp.Services
{
    public class BenFordLawService : IBenFordLawService
    {
        private static readonly char[] ByteSets = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        public FrequencyOfOccurrence[] VerifyDataSet(double[] integerSet)
        {
            var integerSetAsSetOfString = integerSet.Select(x => x.ToString()).ToArray();

            var frequencyOfOccurrenceArray = new FrequencyOfOccurrence[9];

            for (var i = 0; i < ByteSets.Length; i++)
            {
                var integersWithDigit = integerSetAsSetOfString.Where(x => x[0] == ByteSets[i]).ToArray();

                var digit = char.GetNumericValue(ByteSets[i]);

                var expectedFrequency = Math.Round(Math.Log10(1 + (1.0 / digit)), 2);

                if (integersWithDigit.Length == 0)
                {
                    frequencyOfOccurrenceArray[i] = new FrequencyOfOccurrence
                    {
                        Integer = i + 1,
                        Percentage = 0,
                        Count = 0,
                        ExpectedCount = expectedFrequency * integerSetAsSetOfString.Length,
                        ExpectedPercentage = expectedFrequency
                    };

                    continue;
                }

                frequencyOfOccurrenceArray[i] = new FrequencyOfOccurrence
                {
                    Integer = i + 1,
                    Percentage = integersWithDigit.Length / (double)integerSetAsSetOfString.Length,
                    Count = integersWithDigit.Length,
                    ExpectedCount = expectedFrequency * integerSetAsSetOfString.Length,
                    ExpectedPercentage = expectedFrequency
                };
            }

            return frequencyOfOccurrenceArray;
        }
    }
}
