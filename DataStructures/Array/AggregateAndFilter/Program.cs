using System.Collections;

namespace AggregateAndFilter
{
    class Program
    {
        /// <summary>
        /// Method to aggregate array informtaion and only even numbers from the datasets
        /// </summary>
        /// <param name="array1">First array</param>
        /// <param name="array2">Second array</param>
        /// <returns></returns>
        static int[] FindEvenNumber(int[] array1, int[] array2)
        {
            ArrayList arrayList = new ArrayList();

            //Loop entirely through array 1 and find even number elements adding them to the array list
            foreach (int i in array1)
            {
                if (i % 2 == 0)
                {
                    arrayList.Add(i);
                }
            }

            //Loop entirely through array 2 and find even number elements adding them to the array list
            foreach (int i in array2)
            {
                if (i % 2 == 0)
                {
                    arrayList.Add(i);
                }
            }

            return (int[])arrayList.ToArray(typeof(int));
        }

        static void Main(string[] args)
        {
            int[] myArray = { 2, 3, 4, 5, 3, 2, 3, 5, 8, 0, 7, 4, 12, 14, 23, 24, 35, 37, 34 };
            int[] myArray2 = { 2, 3, 4, 5, 3, 4, 12, 14, 23, 24, 35, 37, 34 };

            int[] result = FindEvenNumber(myArray, myArray2);
            Array.ForEach(result, Console.WriteLine);
        }
    }
}