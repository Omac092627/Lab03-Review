using System;

namespace SystemIO
{
    public class Program
    {
        /// <summary>
        /// A main method that calls my weak methods
        /// We start by Calling it, with parenthesis
        /// </summary>
        static void Main(string[] args)
        {
            StartItUp();
            ChallengeTwo();
        }


        /// <summary>
        /// The StartItUp() method begins by asking the user to enter 3 numbers
        /// Followed by stringifying the users input and converting to string
        /// Then I call my canReturnInputNumber() method with the parameter of pickSomething, the submitted
        /// code that's been converted to string.
        /// </summary>
        static void StartItUp()
        {
            Console.WriteLine("Please supply 3 numbers: ");
            string pickSomething = Convert.ToString(Console.ReadLine());
            canReturnInputNumber(pickSomething);
        }

        /// <summary>
        /// I call the canReturnInputNumber in order to perform the logic needed to perform what I'm asking.
        /// 1.I start by stringifying the input and combinging with a Split(). 
        ///     - This allows the input to be split with delimetters.
        /// 2. The assignment then calls for to first allow an array of 3 numbers to be inputted
        ///     - The if statement tests whether the length is less than 3
        /// 3. Then I need to declare a new int array and an int in order to store and multiply
        ///     - I follow up with a for loop, hard coded, that loops through 3 numbers.
        ///     - I then follow with an if statement that also converts a string to an integer and returns a value
        ///         - It's called TryParse() and it's sick
        ///     - Finally, I multiply the product x 1 in order to return the value.
        ///         - The one is so I get the value of the array back
        ///     - Lastly, I call the writeLine method in order to display what the user entered back to them
        ///         - followed by returning the product.
        /// </summary>
        public static int canReturnInputNumber(string input)
        {

            Console.ReadLine();
            string[] stringArray = input.Split(' ');


            if (stringArray.Length < 3)
            {
                return 0;
            }

            int product = 1;
            int[] intArray = new int[3];

            for (int i = 0; i < 3; i++)
            {
                //if this stuff is true//
                if (int.TryParse(stringArray[i], out int returnValue))
                {
                    product *= returnValue;
                }
                else
                {
                    product *= 1;
                }
            }
            Console.WriteLine($"The product of these 3 numbers is: {product}");
            return product;
        }
        public static void ChallengeTwo()
        {

            Console.WriteLine("Please enter a number between 2 and 10: ");
            string entered = Console.ReadLine();
            if (!int.TryParse(entered, out int result))
            {
                throw new Exception("You did not enter a number. Please enter a number:");
            }
            else if (result < 2 || result > 10)
            {
                throw new Exception("You must enter a number between 2 and 10");

            }
            else
            {
                int[] newArray = new int[result];

                for (int i = 0; i < result; i++)
                {
                    Console.WriteLine($"Please enter a number {i + 1}/{result}");
                    string enteredNumber = Console.ReadLine();

                    if (int.TryParse(enteredNumber, out int results))
                    {
                        newArray[i] = results;
                    }
                    else
                    {
                        throw new Exception("Please enter a valid number");
                    }
                }
                decimal average = ChallengeTwoAverage(newArray);
                Console.WriteLine($"Your average is {average}");

            }

        }

        public static decimal ChallengeTwoAverage(int[] sum)
        {
            decimal total = 0;
            for(int i = 0; i < sum.Length; i++)
            {
                total += sum[i];
            }
            return total /= sum.Length;

        }




    }

}



