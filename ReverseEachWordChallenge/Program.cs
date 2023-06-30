using System.Globalization;

namespace ReverseEachWordChallenge
{
    class Program
    {
        static string ReverseString(string input)
        {
            if(string.IsNullOrEmpty(input)) return input;

            char[] chars = input.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
            
        }
        static void Main(string[] args)
        {
            //Input: A string
            //Output: A new string with each word reversed
            Console.WriteLine("Enter the sentence needed");
            string inputName = Console.ReadLine();

            Console.WriteLine($"The input string is: {inputName}");
            Console.WriteLine($"The reverse of each word is: {ReverseString(inputName)}");
           
            
        }
    }
}