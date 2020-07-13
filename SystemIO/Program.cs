using System;
using System.IO;

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
            //string path = "../../words.txt";

            //StartItUp();
            // ChallengeTwo();
            //ChallengeThreeDiamond();
            //ChallengeFour(new int[] { 1, 2, 1, 3, 4, 5, 6, 4 });
            // ChallengeFive();
            //FindAndSaveWriting(path);
            //ReadAllWritingAndPrintToConsole(path);

            GetLengthOfEachWord();
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



        /// <summary>
        /// I prompt the user and ask them to enter a number between 2 and 10. 
        /// I read that information and run a try parse in order to test my conversion.
        /// If everything runs smoothly, it prompts the user that number of times.
        /// After the user has entered the numbers, it takes the sum and provides the average.
        /// </summary>
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
            for (int i = 0; i < sum.Length; i++)
            {
                total += sum[i];
            }
            return total /= sum.Length;

        }


        /// <summary>
        /// This challenge was tricky. I start by propmpting the user to enter the number of rows which act as half
        /// of the diamond.
        /// I then convert the users input followed by activating a forloop. The loop runs through the users 
        /// entered input, which is 8. The first for loop is calculating the spaces while the second one is incrementing
        /// "*" symbol and building up to 8 rows. 
        /// The following for loop below it does the same thing.
        /// </summary>
        public static void ChallengeThreeDiamond()
        {
            int i, j, r;

            Console.Write("\n\n");
            Console.Write("Display the pattern like diamond:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Input number of rows (half of the diamond) :");
            r = Convert.ToInt32(Console.ReadLine());
            for (i = 0; i <= r; i++)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = r - 1; i >= 1; i--)
            {
                for (j = 1; j <= r - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }
        }


        /// <summary>
        /// Calculate the average of the inputted integers.
        /// Return the frequency of integers.
        /// Check if the numbers duplicate or not
        /// Return first number if no duplicates
        /// </summary>
        /// <param name="numberArray"></param>
        /// <returns></returns>
        public static int ChallengeFour(int[] numberArray)
        {
            //counters to know the frequency//
            int counter = 0;
            int freq = 0;

            //arrays for entered and frequency//
            int numbers = numberArray[0];
            int frontNumbers = numberArray[0];

            for (int i = 0; i < numberArray.Length; i++)
            {
                counter = 0;
                for (int a = 0; a < numberArray.Length; a++)
                {
                    if (numberArray[i] == numberArray[a])
                    {
                        counter += 1;
                        frontNumbers = numberArray[i];
                    }
                }
                if (freq < counter)
                {
                    numbers = frontNumbers;
                    freq = counter;
                }
            }
            return freq;

        }



        /// <summary>
        /// I declare an int to hold my array and put some variable in to mitigate workload.
        /// I prompt the user to enter the amount of numbers they want in array.
        /// After I propmt the user the number of times they entered.
        /// I loop through the users input to find the max value.
        /// </summary>
        /// <returns></returns>

        public static int ChallengeFive()
        {
            int[] arr1 = new int[100];
            int i, mx, n;


            Console.Write("\n\nFind maximum and minimum element in an array :\n");
            Console.Write("--------------------------------------------------\n");

            Console.Write("Input the number of elements to be stored in the array :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            mx = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }
            }
            Console.Write("Maximum element is : {0}\n", mx);
            return 0;
        }


        /// <summary>
        /// Appending a file with words. Calling the path method in the static method at the top.
        /// </summary>
        /// <param name="path"></param>

        static void FindAndSaveWriting(string path)
        {
            Console.WriteLine("Enter something or die:");
            string word = Console.ReadLine();
            File.AppendAllText(path, word);
            ReadTheFileandRemoveOneWord(path, word);

        }

        /// <summary>
        /// Reading and writing the file back to the console
        /// </summary>
        /// <param name="path"></param>

        static void ReadAllWritingAndPrintToConsole(string path)
        {

            string[] allLines = File.ReadAllLines(path);
            Console.WriteLine(String.Join('\n', allLines));

        }

        /// <summary>
        /// First i instantiate the reading of the file
        /// Then split the words to separate what I want to remove
        /// Followed by a for loop to loop through my words
        /// If my words are there from previous, delte them
        /// Followed by joining my new words
        /// </summary>
        /// <param name="path"></param>
        /// <param name="removeThisWord"></param>

        static void ReadTheFileandRemoveOneWord(string path, string removeThisWord)
        {
            string stringInFile = File.ReadAllText(path);

            string[] words = stringInFile.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == removeThisWord)
                {
                    words[i] = "";
                }

                string newString = String.Join(" ", words);

                File.WriteAllText(path, newString);
            }
        }

        static void GetLengthOfEachWord()
        {
            Console.WriteLine("PLEASE ENTER A SENTENCE:");
            string words = Console.ReadLine();
            string[] wordsArray = words.Split(" ");
            string[] count = new string[wordsArray.Length * 2];


            for (int i = 0; i < wordsArray.Length; i++)
            {
                count[i] = ( $"{String.Join(',', wordsArray[i])}: {String.Join(',', wordsArray[i].Length)}");
            }
            Console.WriteLine(count);

        }


    }

}



