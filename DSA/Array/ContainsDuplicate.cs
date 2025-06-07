using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array;
internal class ContainsDuplicate
{
    public bool ContainsDuplicate_v1(int[] nums)
    {
        var map = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            if (map.ContainsValue(nums[i]))
                return true;
            else
                map.Add(i, nums[i]);
        }

        return false;
    }

    public bool ContainsDuplicate_v2(int[] nums)
    {
        var exisitingItems = new HashSet<int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (exisitingItems.Contains(nums[i]))
                return true;
            else
                exisitingItems.Add(nums[i]);
        }

        return false;
    }
}
