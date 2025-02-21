using System.Text.RegularExpressions;

namespace String.Q125;

public class Program
{
    public static bool IsPalindrome(string s) {

        // Remove all non-alphanumeric characters and convert to lowercase
        s = Regex.Replace(s, "[^a-zA-Z0-9]", "").ToLower();

        // Use a single loop to compare characters
        var len = s.Length;
        for (var i = 0; i < len / 2; i++)
        {
            if (s[i] != s[len - (i + 1)])
                return false;
        }
        return true;      
    }
}