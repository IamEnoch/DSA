namespace Array.Q121;

public class Program
{
    public static int MaxProfit(int[] prices) {
        var minPrice = int.MaxValue;
        var maxProfit = 0;
        
        foreach (var price in prices) {
            minPrice = Math.Min(minPrice, price);
            var profit = price - minPrice;
            maxProfit = Math.Max(maxProfit, profit);
        }
        return maxProfit;
    }
}