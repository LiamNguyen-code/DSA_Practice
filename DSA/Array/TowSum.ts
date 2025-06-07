/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function (nums, target) {
    for (let i = 0; i < nums.length; i++) {
        for (let j = i + 1; j < nums.length; j++) {
            if (nums[i] + nums[j] == target)
                return [i, j];
        }
    }
    return [];
};

var twoSum_ver2 = function (nums, target) {
    let map = new Map();
    for (let i = 0; i < nums.length; i++) {
        let complement = target - nums[i];
        if (map.has(complement))
            return [i, map.get(complement)];
        else
            map.set(nums[i], i);
    }
    return [];
};

//https://leetcode.com/problems/two-sum/description/