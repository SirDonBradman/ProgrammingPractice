using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        //function to print a set
        static void printSet(HashSet<int> set)
        {
            foreach(var item in set)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        //add the cuurent set to the result set
        static void addSetToResult(List<HashSet<int>> results, int?[] set)
        {
            HashSet<int> resultSet = new HashSet<int>();
            foreach(var number in set)
            {
                if (number != null)
                    resultSet.Add(number.GetValueOrDefault());
            }
            results.Add(resultSet);
        }

        //recursively generate all the subsets of this set
        static void computeSubsets(HashSet<int> set, List<HashSet<int>> results, int?[] currentSet, int index)
        {
            if (index == currentSet.Length)
            {
                addSetToResult(results, currentSet);
            }
            else
            {
                //compute the subset excluding the current item
                currentSet[index] = null;
                computeSubsets(set, results, currentSet, index + 1);

                //compute the subset including the current item
                currentSet[index] = set.ElementAt(index);
                computeSubsets(set, results, currentSet, index + 1);
            }
        }

        static List<HashSet<int>> getAllSubsets(HashSet<int> set)
        {
            List<HashSet<int>> results = new List<HashSet<int>>();
            int?[] currentSet = new int?[set.Count];

            computeSubsets(set, results, currentSet, 0);
            return results;
        }

        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>()
            {
                1,2,3,4
            };
            
            var subsets = getAllSubsets(set);
            foreach (var subset in subsets)
                printSet(subset);
        }
    }
}
