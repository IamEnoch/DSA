namespace Array.Q1;

public partial class Program
{
    public static int[] TwoSum(int[] nums, int target) {
        for(var i = 0; i < nums.Length; i++)
        {
            for(var k = 0; k < nums.Length; k++)
            {
                if(i == k) continue;
                if((nums[k] + nums[i]) == target)
                    return [i, k];
            }
        }
        return [];    
    }
}