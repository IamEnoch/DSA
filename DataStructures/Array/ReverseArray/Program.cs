namespace ReverseArray
{
    public static class Program
    {
        static int[] ReverseArray(int[] inputArray)
        {
            //Array to store the reversed elements
            int[] reversedArray = new int[inputArray.Length];

            //For loop to add each elements from the far right of the array
            for(int i =  0; i < inputArray.Length; i++)
            {
                reversedArray[i] = inputArray[inputArray.Length - 1 - i];
            }

            return reversedArray;
        }

        private static void Main(string[] args)
        {
            int[] testArray = {1,2,3,4,2,5,4,3,4,6,7,4,4,6,6};
            Array.ForEach(ReverseArray(testArray), Console.Write); //Expected output: 664476434524321
            
        }
    }
}