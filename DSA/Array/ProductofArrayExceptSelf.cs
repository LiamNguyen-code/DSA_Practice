using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array;
internal class ProductofArrayExceptSelf
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var result = new int[nums.Length];
        var newItem = 1;
        for (var j = 0; j < nums.Length; j++)
        {
            for (var i = 0; i < nums.Length; i++)
            {
                if (i != j)
                {
                    newItem *= nums[i];
                }
            }

            result[j] = newItem;
            newItem = 1;
        }
        return result;
    }

    public int[] ProductExceptSelf_v2(int[] nums)
    {
        var result = new int[nums.Length];
        var leftArray = new int[nums.Length];
        for (var i = 0; i < nums.Length; i++)
        {
            if (i == 0)
                leftArray[0] = 1;
            else
                leftArray[i] = leftArray[i - 1] * nums[i - 1];
        }

        var rightArray = new int[nums.Length];
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            if (i == nums.Length - 1)
                rightArray[nums.Length - 1] = 1;
            else
                rightArray[i] = rightArray[i + 1] * nums[i + 1];

            result[i] = leftArray[i] * rightArray[i];
        }

        return result;
    }

    public int[] ProductExceptSelf_v3(int[] nums)
    {
        var result = new int[nums.Length];

        var leftNum = 1;
        for (var i = 1; i < nums.Length; i++)
        {
            result[i-1] = leftNum;
            leftNum *= nums[i - 1];
        }

        var rightNum = 1;
        for (var i = nums.Length - 1; i >= 0; i--)
        {
            result[i] *= rightNum;
            rightNum *= nums[i+1];
        }

        return result;
    }
}
