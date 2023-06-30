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
        static void Main(String[] args)
        {
            string inputName;
            Console.WriteLine("Enter the word you wish to reverse");
            inputName = Console.ReadLine();

            Console.WriteLine($"The reverse of {inputName} is: {ReverseString(inputName)}");

        }
    }
}