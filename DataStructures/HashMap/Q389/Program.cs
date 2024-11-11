namespace HashMapImplementation.Q389;

public static partial class Program
{
    private static char FindTheDifference(string s, string t)
    {
        var items = new Dictionary<char, int>();

        // Register the occurence of the characters in a hash map
        foreach (var c in s.Where(c => !items.TryAdd(c, 1)))
            items[c]++;

        foreach (var c in t)
        {
            if (!items.TryGetValue(c, out var value) || value == 0)
                return c; // This character was added

            items[c] = --value;
        }

        // Check for the character that has only one occurrence
        return items.FirstOrDefault(x => x.Value == 1).Key;
    }
}