namespace Array.Q704;

public class Program
{
    public static int Search(int[] nums, int target) {
        // Declare the pointers that define the search space
        var left = 0;
        var right = nums.Length - 1;

        while(left <= right)
        {
            var mid = left + (right - left) / 2;

            if(nums[mid] == target)
                return mid;

            if(nums[mid] < target)
                left = mid + 1;
            else
            {
                right = mid - 1;
            }
        } 
        return -1;                       
    }
}