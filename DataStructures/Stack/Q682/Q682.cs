namespace Stack.Q682;

public class Q682
{
    public int CalPoints(string[] operations)
    {
        var records = new Stack<int>();
        var totalCount = 0;

        foreach (var operation in operations)
            switch (operation)
            {
                case "+":
                    var second = records.Pop();
                    var first = records.Peek();
                    records.Push(second);
                    records.Push(first + second);
                    break;
                case "D":
                    records.Push(records.Peek() * 2);
                    break;
                case "C":
                    records.Pop();
                    break;
                default:
                    records.Push(int.Parse(operation));
                    break;
            }

        while (records.Count > 0)
            totalCount += records.Pop();

        return totalCount;
    }
}