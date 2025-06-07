/**
 * @param {number[]} nums
 * @return {boolean}
 */
var containsDuplicate = function (nums) {

    const existingItems = new Set();

    for (let num of nums) {
        if (existingItems.has(num)) {
            return true;
        }
        existingItems.add(num);
    }

    return false;
};