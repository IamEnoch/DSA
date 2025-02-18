namespace BinarySearch;

internal static class Program
{
    /// <summary>
    /// Method to perform binary search
    /// </summary>
    /// <param name="array">Input array(Sorted and ascending)</param>
    /// <param name="item">Specific item</param>
    /// <returns></returns>
    private static bool BinarySearch(int[] array, int item)
    {
        //Variable to store the min and max and mid
        var min = 0;
        var max = array.Length - 1;

        //Search completes when max is less than min
        while (min <= max)
        {
            //calculate mid
            var mid = (min + max) / 2;
            if (array[mid] == item) return true;

            if (item > array[mid])
                min = mid + 1;
            else
                max = mid - 1;
        }

        return false;
    }

    private static void Main(string[] args)
    {
        int[] myArray = { 2, 3, 7, 9, 11, 20 };
        //Find if number 11 exists
        Console.WriteLine(BinarySearch(myArray, 11)); //Expected output: True


        //Find if number 30 exists
        Console.WriteLine(BinarySearch(myArray, 30)); //Expected output: False

        Console.WriteLine();

        //Using the inbuit binary search method
        Console.WriteLine(Array.BinarySearch(myArray, 11)); //Expected output: 4
        Console.WriteLine(Array.BinarySearch(myArray, 30)); //Expected output: -7
    }
}