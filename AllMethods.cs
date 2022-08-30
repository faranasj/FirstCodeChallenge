using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallengeOne
{
    public class AllMethods
    {
        public int MinimumNumberOfCandies(int numberOfChildren, int[] ratings)
        {
            int counter = 0;

            for (int i = 0; i < ratings.Length; i++)
            {
                if (ratings[i + 1] > ratings[i])
                {
                    return counter+1;
                }
                else if (ratings[i + 1] < ratings[i])
                {
                    counter++;
                }
            }
            return counter;
        }

        public string CommonChild(string firstString, string secondString)
        {
            int counter = 0;

            firstString.ToCharArray();
            secondString.ToCharArray();

            for (int t = 0; t < firstString.Length; t++)
            {
                for (int m = 0; m < secondString.Length; m++)
                {
                    if (firstString[t] == secondString[m])
                    {
                        counter++;
                    }
                }
            }
            return counter;
        }
    }
}