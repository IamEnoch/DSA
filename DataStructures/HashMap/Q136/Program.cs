namespace HashMapImplementation.Q136;

public class Program
{
    public static int SingleNumber(int[] nums)
    {
        var items = new Dictionary<int, int>();

        foreach (var t in nums)
            if (!items.TryAdd(t, 1))
                items[t]++;

        return items.FirstOrDefault(x => x.Value == 1).Key;
    }
}