using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
//AMunoz
/* Program to create combinations of characters 
 * without repeating the numbers (not permutations) */

namespace ConsoleAppSimpleCombination
{
    class Program
    {
        static void Main(string[] args)
        {

            //input values; this can be changed to manual input on screen
            string[] values = { "1", "2", "3", "4", "16", "A", "B", "C", "D" };

            List<string> valuesList = new List<string>(values.Length);
            valuesList.AddRange(values);

            //function CreateCombinations() receives two params: the values from the array, and the number of combinations
            //the number of combinations can be changed to be entered manually
            var getValuesCombined = CreateCombinations(valuesList, 3);

            foreach (var v in getValuesCombined)
            {
                foreach (var c in v)
                {
                    Console.Write(c.ToString() + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Function CreateCombinations() receives two params: the values from the array, and the number of combinations.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="items"></param>
        /// <param name="count"></param>
        /// <returns></returns>
        public static IEnumerable<IEnumerable<T>> CreateCombinations<T>(IEnumerable<T> items, int count)
        {
            int i = 0;
            foreach (var item in items)
            {
                if (count == 1)
                {
                    yield return new T[]
                    {
                        item
                    };
                }
                else
                {
                    foreach (var result in CreateCombinations(items.Skip(i + 1), count - 1))
                    {
                        yield return new T[] { item }.Concat(result);
                    }
                    ++i;
                }
            }
        }
    }
}
