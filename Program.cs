using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nick";
            int cohort = 34;
            int theBestCohort = 35;

            // reassigning variables
            name = "Jisie";
            cohort = 35;

            // string concatenation
            string greeting = "Hello " + name + ". Welcome to cohort " + cohort;

            // String interpolation
            string greeting2 = $"Hello {name}. Welcome to Cohort {cohort}";

            bool isTheBest = cohort == theBestCohort;

            if (isTheBest)
            {
                Console.WriteLine("Ah, the best around.");
            }
            else if (name == "Jisie")
            {
                Console.WriteLine("Well, not in the right Cohort. But she's here");
            }
            else
            {
                Console.WriteLine("You may... want to rethink your descision");
            }
            // Loops

            // For Loops
            int[] cohorts = new int[] { 34, 35, 36, 37 };

            for (int i = 0; i < cohorts.Length; i++)
            {
                Console.WriteLine($"Cohort {cohorts[i]}");
            }

            // For Each Loops 
            foreach (int item in cohorts)
            {
                Console.WriteLine($"Cohort {item}");
            }

            // While Loops 
            while (cohort > 0)
            {
                cohort--;
                Console.WriteLine(cohort);
            }

        }
    }
}