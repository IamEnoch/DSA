namespace BigO
{
    class Program
    {        
        static void Main(string[] args)
        {
            //Function that square the input number
            int SqureMethod(int a)
            {
                return a * a;
            }

            //Function that square a number and increments the result by one
            int SquareandIncrement(int b)
            {
                int result = SqureMethod(b);
                return ++result;
            }
                        
            Console.WriteLine("Enter the number you wish to square");

            //Get the numner in string number from the console
            var name = Console.ReadLine();

            //Parse the string number to generate an integer
            int nameInt = int.Parse(name);
            Console.WriteLine($"The square of the number is: {SqureMethod(nameInt)}");
            Console.WriteLine($"The square of the number with an incrementation is: {SquareandIncrement(nameInt)}");
        }
    }
}

