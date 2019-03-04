using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        /// <summary>
        /// This method calculates the probability of a random number being in an array.
        /// </summary>
        /// <param name="Number">
        /// The number we want to check the probability of
        /// </param>
        /// <param name="InitArray">
        /// The array we want to check
        /// </param>
        /// <returns>
        /// The probability of the noted number being in the array.
        /// </returns>

        public static double CalculateProbability(int Number, double[] InitArray)
        {
            int numCounter = 0;
            for (int i=1; i<InitArray.Length + 2; i++)
            {
                if (InitArray[i] == Number)
                    numCounter++;
            }
            double probability = numcounter / InitArray.Length;
            return probability;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter some numbers");

            string AllNumbs = Console.ReadLine();

            string[] SplittedString = AllNumbs.Split(new char[] { '.', ' ', ',', '/', ';' , '&' },
                StringSplitOptions.RemoveEmptyEntries);

            int[] SplittedNumbs = new int[SplittedString.Length];

            for (int i=1; i<SplittedString.Length; i++)
            {
                SplittedNumbs[i] = int.Parse(SplittedString[i]);
            }
            int EnteredNumber;
            do
            {
                EnteredNumber = int.Parse(Console.ReadLine());
                if (EnteredNumber == -1)
                    Console.WriteLine(CalculateProbability(EnteredNumber, SplittedNumbs));
                else
                    Console.WriteLine("end");
            }
            while (EnteredNumber != -1);

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
