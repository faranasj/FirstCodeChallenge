using System;

namespace CodeChallengeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of children in class: ");
            int numberOfChildren = int.Parse(Console.ReadLine());
            int[] ratings = {numberOfChildren};

            for (int i = 0; i < numberOfChildren; i++)
            {
                Console.Write("Enter ratings of each child: ");
                ratings[i] = int.Parse(Console.ReadLine());
            }

            AllMethods candies = new AllMethods();
            int minimumNoOfCandies = candies.MinimumNumberOfCandies(numberOfChildren, ratings);
            Console.WriteLine($"The minimum number of candies Alice gave to each children is {minimumNoOfCandies}");

            Console.Write("Enter first word: ");
            string firstWord = Console.ReadLine();
            Console.Write("Enter second word: ");
            string secondWord = Console.ReadLine();

            AllMethods result = new AllMethods();
            int commonChild = result.CommonChild(firstWord, secondWord);
            Console.WriteLine($"The lenght of the longest string which is a comon child of the input string is {commonChild}");


        }
    }
}
