namespace Array.Q169;

public class Program
{
    public static int MajorityElement(int[] nums) {
        var maxapp = nums.Length / 2;
        var ht = new Dictionary<int, int>();
        foreach(var num in nums)
        {
            ht.TryAdd(num, 0);
            ht[num]++;

            if(ht[num] > maxapp)
                return num;
        }
        return -1;        
    }
}