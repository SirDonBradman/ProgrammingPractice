using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class AllPermutationsOfString
    {
        static string swapCharacters(string source, int index1, int index2)
        {
            var sourceArray = source.ToArray();
            var temp = sourceArray[index1];
            sourceArray[index1] = sourceArray[index2];
            sourceArray[index2] = temp;
            return new string(sourceArray);
        }

        static void getPermutations(string source, int left, int right)
        {
            if (left == right)
            {
                Console.WriteLine(source);
                return;
            }

            for (int i = left; i <= right; i++)
            {
                source = swapCharacters(source, left, i);
                getPermutations(source, left + 1, right);
                source = swapCharacters(source, left, i);
            }
        }
        public static void get(string source)
        {
            getPermutations(source, 0, source.Length-1);
        }
    }
}
