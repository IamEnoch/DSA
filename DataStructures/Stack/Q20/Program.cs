namespace Stack.Q20;

public class Program
{
    public static bool IsValid(string s)
    {
        var entries = new Stack<char>();
        foreach (var element in s)
        {
            if (element is '(' or '[' or '{')
                entries.Push(element);

            if (entries.Count == 0 && element is ')' or ']' or '}')
                return false;

            switch (element)
            {
                case ')':
                    // Peek stack to check for '('
                    if (entries.Peek() == '(')
                        entries.Pop();
                    else
                        return false;
                    break;
                case '}':
                    // Peek stack to check for '{'
                    if (entries.Peek() == '{')
                        entries.Pop();
                    else
                        return false;
                    break;
                case ']':
                    // Peek stack to check for '['
                    if (entries.Peek() == '[')
                        entries.Pop();
                    else
                        return false;
                    break;
            }
        }

        return entries.Count == 0;
    }
}