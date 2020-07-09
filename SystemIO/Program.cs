using System;

namespace SystemIO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
        }

        public static int canReturnInputNumber(string input)
        {
            string[] stringArray = input.Split(' ');

            if (stringArray.Length < 3)
            {
                return 0;
            }
            return 0;
        }



    }
}


