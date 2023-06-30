namespace StringAlgorithms
{
    class Program
    {
        //Check if a string is uppercase
        static bool IsUppercase(string name)
        {
            return name.All(char.IsUpper);
        }

        //Check if a string is lowercase
        static bool IsLowercase(string name)
        {
            return name.All(char.IsLower);
        }

        //Passowrd validtor
        //Checks is password has at least one lowercase letter, one uppercase letter and one digit
        static bool IsPasswordComplex(string name)
        {
            return name.Any(char.IsDigit) && name.Any(char.IsUpper) && name.Any(char.IsLower);
        }
        static void Main(string[] args)
        {
            //Test IsUppercase and IsLowercase methods
            Console.WriteLine(IsUppercase("Hello")); //Expected answer: False
            Console.WriteLine(IsUppercase("HELLO")); //Expected answer: True
            Console.WriteLine();

            Console.WriteLine(IsLowercase("Hello")); //Expected answer: False
            Console.WriteLine(IsLowercase("Hello")); //Expected answer: False
            Console.WriteLine();

            //Test IsPasswordComplex method
            Console.WriteLine(IsPasswordComplex("ValidateString")); //Expected answer: False
            Console.WriteLine(IsPasswordComplex("ValidateString2")); //Expected answer: True
        }
    }
}