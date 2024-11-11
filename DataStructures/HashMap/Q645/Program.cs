namespace HashMapImplementation.Q645;

public partial class Program
{
    private static int[] FindErrorNums(int[] nums)
    {
        // Sort the array
        Array.Sort(nums);

        // Initialize a dictionary to keep track of occurrences
        var items = new Dictionary<int, int>();
        int duplicate = -1, missing = -1;

        foreach (var t in nums)
            if (!items.TryAdd(t, 1))
                duplicate = t;

        // Check for missing number from 1 to n
        for (var i = 1; i <= nums.Length; i++)
            if (!items.ContainsKey(i))
            {
                missing = i;
                break;
            }

        return new[] { duplicate, missing };
    }
}