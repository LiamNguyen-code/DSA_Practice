using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array;
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        for (var i = 0; i < nums.Length; i++)
        {
            for (var y = i + 1; y < nums.Length; y++)
            {
                if ((nums[i] + nums[y]) == target)
                    return new int[] { i, y };
            }
        }

        return new int[] { };
    }

    public int[] TwoSum2(int[] nums, int target)
    {

        var map = new Dictionary<int, int>(); //number - index
        for (var i = 0; i < nums.Length; i++)
        {
            var complement = target - nums[i];
            if (map.ContainsKey(complement))
            {
                return new int[] { map[complement], i };
            }

            if (!map.ContainsKey(complement))
            {
                map[nums[i]] = i;
            }
        }

        return new int[] { };
    }
}

//https://leetcode.com/problems/two-sum/description/
