// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
//https://leetcode.com/discuss/post/460599/blind-75-leetcode-questions-by-krishnade-9xev/


var output = ProductExceptSelf_v2(new int[] { 1, 2, 3, 4 });

int[] ProductExceptSelf_v2(int[] nums)
{
    var result = new int[nums.Length];
    var leftArray = new int[nums.Length];
    for (var i = 0; i < nums.Length; i++)
    {
        if (i == 0)
            leftArray[0] = 1;
        else
            leftArray[i] = leftArray[i-1] * nums[i - 1];
    }

    var rightArray = new int[nums.Length];
    for (var i = nums.Length - 1; i >= 0; i--)
    {
        if(i == nums.Length - 1)
            rightArray[nums.Length - 1] = 1;
        else
            rightArray[i] = rightArray[i+1] * nums[i + 1];

        result[i] = leftArray[i] * rightArray[i];
    }
    
    return result;
}