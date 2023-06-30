using System.Globalization;

namespace NormalizeStrings
{
    class Program
    {
        //Normalize string method 
        static string NormalizeStringMethod(string name)
        {
            //Make the string lowercase, remove whitespaces from start to end of the string and remove ','
            var normalized = name.ToLower().Trim().Replace(",", "");
            return normalized;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(NormalizeStringMethod(" The name of the stree is called chECK ")); //Expected output: the name of the stree is called check

        }
    }
}