using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array;
internal class MaximumSubarray
{
    public int MaxSubArray_v1(int[] nums)
    {
        var max = 0;
        var tempSum = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            tempSum = 0;
            for (var j = i; j < nums.Length; j++)
            {
                tempSum += nums[j];
                if (max < tempSum)
                    max = tempSum;
            }
        }

        return max;
    }

    public int MaxSubArray(int[] nums)
    {
        var max = nums[0];
        var currentSum = nums[0];

        for (var i = 1; i < nums.Length; i++)
        {
            currentSum += nums[i];
            if (currentSum < nums[i])
                currentSum = nums[i];

            if (currentSum > max)
                max = currentSum;
        }

        return max;
    }
}
