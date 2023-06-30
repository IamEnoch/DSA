using System.Text;

namespace AlgorithDrivenString
{
    class Program
    {
        //Reversing the string using a string builder
        static string ReverseString(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                return name;
            }

            StringBuilder reverseString = new StringBuilder();
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reverseString.Append(name[i]);
            }

            return reverseString.ToString();
        }

        //Reversing the string using an array
        static string ReverseStringArray(string name)
        {
            if(string.IsNullOrEmpty(name))
            {
                return name;
            }

            char[] chars = name.ToCharArray();

            Array.Reverse(chars);

            return new string(chars);
        }
        static void Main(String[] args)
        {
            string inputName;
            Console.WriteLine("Enter the word you wish to reverse");
            inputName = Console.ReadLine();

            Console.WriteLine($"The reverse of {inputName} is: {ReverseString(inputName)}"); 
            Console.WriteLine($"The reverse of {inputName} using an array is: {ReverseStringArray(inputName)}");

        }
    }
}