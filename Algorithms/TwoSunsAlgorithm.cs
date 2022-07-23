using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public static class TwoSunsAlgorithm
    {
        private static int target;
        private static List<int> numbers = new List<int>();
        private static string result = "";

        public static void CalculateTwoSunsAlgorithm(int _target, int[] _numbers)
        {
            target = _target;
            numbers = _numbers.ToList();
            result = CalculateResult();

            DisplayResult();
        }



        private static string CalculateResult()
        {
            for (int i = 0; i < numbers.Count; i++)
            { 
                numbers.Select(x => x != numbers[i]);
               
                for (int j = 0; j < numbers.Count; j++)
                {
                    if (numbers[i] + numbers[j] == target)
                    {
                        return $"[{numbers[i]}, {numbers[j]}]";
                    }

                }

            }
            return "No result found";
        }



        private static void DisplayResult()
        {
            Console.WriteLine($"The result for [{string.Join(", ", numbers)}] and target: {target} is: {result}");
        }

    }
}
