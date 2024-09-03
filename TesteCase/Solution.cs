using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteCase
{
    public class Solution
    {
        public bool CheckSubarraySum(int[] nums, int k)
        {
            // Dicionário para armazenar o resto da soma acumulada e o índice correspondente
            Dictionary<int, int> remainderDict = new Dictionary<int, int>();
            remainderDict[0] = -1;
            int cumulativeSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                cumulativeSum += nums[i];
                int remainder = cumulativeSum % k;

                if (remainderDict.ContainsKey(remainder))
                {
                    if (i - remainderDict[remainder] > 1)
                    {
                        return true;
                    }
                }
                else
                {
                    remainderDict[remainder] = i;
                }
            }

            return false;
        }
    }
}
