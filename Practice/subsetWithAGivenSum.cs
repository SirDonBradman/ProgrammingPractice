using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class subsetWithAGivenSum
    {
        static bool computeAllSubsetsWithSum(HashSet<int> set, int sum, int index)
        {
            if (index == set.Count)
            {
                return false;
            }
            if (sum == 0)
            {
                return true;
            }
            if (sum < set.ElementAt(index))
            {
                computeAllSubsetsWithSum(set, sum, index + 1);
            }

            return
                //compute subsets without the current element
                computeAllSubsetsWithSum(set, sum, index + 1)
                    ||
                //compuet the subsets with the current element
                computeAllSubsetsWithSum(set, sum - set.ElementAt(index), index + 1);
        }

        //static void Main(string[] args)
        //{
        //    HashSet<int> set = new HashSet<int>()
        //    {
        //        1,2,3,4,5
        //    };
        //    var result = computeAllSubsetsWithSum(set, 20, 0);
        //    Console.WriteLine(result);
        //}
    }
}
