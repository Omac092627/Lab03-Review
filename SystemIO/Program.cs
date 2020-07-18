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
            ChallengeOne();
            ChallengeTwo();
            ChallengeThree();
            ChallengeFour();
            ChallengeFive();
            ChallengeSix();
            ChallengeSeven();
            ChallengeEight();
            ChallengeNine();

        }


        /// <summary>
        /// The StartItUp() method begins by asking the user to enter 3 numbers
        /// Use a multiply method
        /// </summary>
        static void ChallengeOne()
        {
            Console.WriteLine("Please supply 3 numbers: ");
            string pickSomething = Console.ReadLine();

            int output = MultiplyNumber(pickSomething);

            Console.WriteLine($"Your product is: {output}");

        }

        ///create a multiply method to handle the above method///

        public static int MultiplyNumber(string inputString)
        {
            string[] stringArray = inputString.Split(' ');

            if (stringArray.Length < 3)
            {
                return 0;
            }
            int product = 1;

            for (int i = 0; i < 3; i++)
            {
                if (int.TryParse(stringArray[i], out int returnValue))
                {
                    product *= returnValue;
                }
                else
                {
                    product *= 1;
                }
            }
            return product;
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
        static void ChallengeTwo()
        {
            bool isFormatted = false;
            do
            {
                Console.WriteLine("Please enter a number between 2 and 10: ");
                string input = Console.ReadLine();
                bool yes = int.TryParse(input, out int arraySize);

                if (yes && arraySize > 1 && arraySize < 11)
                {
                    isFormatted = callBackChallengeTwo(arraySize);
                }
                else
                {
                    Console.WriteLine("Improper input, try again.");
                    isFormatted = true;
                }

            } while (isFormatted);

        }

        ///Method for non input of a negative number on above method///
        public static bool callBackChallengeTwo(int arraySize)
        {
            bool isFormatted = false;
            try
            {
                int[] methodArray = new int[arraySize];
                for (int i = 0; i < methodArray.Length; i++)
                {
                    Console.WriteLine($"{i + 1} of {methodArray.Length} - Enter a number: ");
                    int inputNumber = Convert.ToInt32(Console.ReadLine());

                    if (inputNumber >= 0)
                    {
                        methodArray[i] = inputNumber;
                    }
                    else
                    {
                        Console.WriteLine("Wrong input, try again.");
                        isFormatted = true;
                        break;
                    }
                }
                if (isFormatted == false)
                {
                    Console.WriteLine(GetAverage(methodArray));
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Wrong input, try again.");
                isFormatted = true;
            }
            return isFormatted;
        }

        ///Add numbers and divide by sum by array length///
        public static decimal GetAverage(int[] inputArray)
        {
            int sum = 0;

            for (int i = 0; i < inputArray.Length; i++)
            {
                sum += inputArray[i];
            }

            decimal sumDecimal = Convert.ToDecimal(sum);
            decimal lengthDecimal = Convert.ToDecimal(inputArray.Length);
            decimal average = sumDecimal / lengthDecimal;

            return average;
        }


        /// <summary>
        /// call method for the diamon builder
        /// </summary>
        static void ChallengeThree()
        {
            Diamond();
        }

        /// <summary>
        /// This makes a diamond. The assignment asks for 9x9. 
        /// The first outer loop builds the top half.
        /// The second outer loop builds the bottom half.
        /// a variable for how big of a diamond you want
        /// </summary>
        public static void Diamond()
        {

            int i, j;

            Console.Write("\n\n");
            Console.Write("Display the pattern like diamond:\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");


            for (i = 0; i <= 5; i++)
            {
                for (j = 1; j <= 5 - i; j++)
                    Console.Write(" ");
                for (j = 1; j <= 2 * i - 1; j++)
                    Console.Write("*");
                Console.Write("\n");
            }

            for (i = 5 - 1; i >= 1; i--)
            {
                for (j = 1; j <= 5 - i; j++)
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
        static void ChallengeFour()
        {
            int[] newArray = new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 };

            int checkDuplicates = Duplicates(newArray);
            Console.WriteLine("Example: input: [1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1]");
            Console.WriteLine($"output: {checkDuplicates}");

        }

        /// <summary>
        /// This method returns the number that has the most duplicates.
        /// Checks each item in the array.
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>

        public static int Duplicates(int[] inputArray)
        {
            int[] newArray = new int[2] { inputArray[0], 0 };

            for (int i = 0; i < inputArray.Length; i++)
            {
                int counter = 0;
                for (int x = 0; x < inputArray.Length; x++)
                {
                    if (inputArray[i] == inputArray[i])
                    {
                        counter++;
                    }

                    if (counter > newArray[1])
                    {
                        newArray[0] = inputArray[i];
                        newArray[1] = counter;
                    }
                }

            }
            int all = newArray[0];
            return all;
        }



        static void ChallengeFive()
        {
            int[] newArray = new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 };

            int findMaxValue = MaxValue(newArray);
            Console.WriteLine("Example: input [5, 25, 99, 123, 78, 96, 555, 108, 4 ] ");
            Console.WriteLine($"return: {findMaxValue}");
        }

        /// <summary>
        /// Starts with first position in array and checks if anything is larger
        /// Once found a larger one, it is checked along with the rest of the array
        /// </summary>
        /// <param name="inputArray"></param>
        /// <returns></returns>
        public static int MaxValue(int[] inputArray)
        {
            int compare = inputArray[0];

            for (int i = 0; i < inputArray.Length; i++)
            {
                if (inputArray[i] > compare)
                {
                    compare = inputArray[i];
                }
            }
            return compare;
        }

        /// <summary>
        /// First get the path
        /// Prompt the user to enter a word
        /// Read the users input
        /// Append the word
        /// </summary>

        static void ChallengeSix()
        {
            string path = "../../../words.txt";

            Console.WriteLine("Enter a word: ");

            string userInput = Console.ReadLine();

            AppendWord(path, userInput);
        }


        /// <summary>
        /// Find the path and append the text
        /// Use catch for two exceptions, one if can't find directory, and another for formatting
        /// </summary>
        /// <param name="path"></param>
        /// <param name="input"></param>
        static void AppendWord(string path, string input)
        {
            try
            {
                File.AppendAllText(path, $"{input}");
            }
            catch (DirectoryNotFoundException)
            {

                Console.WriteLine("Directory doesn't exist");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }


        /// <summary>
        /// Find the path
        /// print the information to console
        /// </summary>

        static void ChallengeSeven()
        {
            string path = "../../../words.txt";

            string output = ReadText(path);
            Console.WriteLine(output);
        }

        /// <summary>
        /// Method to read the text from file
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static string ReadText(string path)
        {
            string result = File.ReadAllText(path);

            return result;
        }


        /// <summary>
        /// Method to choose a word and remove it
        /// string the path
        /// remove the word from the path
        /// </summary>
        static void ChallengeEight()
        {
            string path = "../../../words.txt";

            string remove = ChooseWord(path);

            RemoveWord(path, remove);
        }

        /// <summary>
        /// A method to choose the word
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static string ChooseWord(string path)
        {
            string fromFile = ReadText(path);

            string[] words = fromFile.Split(" ");

            return words[1];
        }

        /// <summary>
        /// Method to remove the word
        /// Turn the words into an array
        /// Find index of word to be removed and remove it
        /// </summary>
        /// <param name="path"></param>
        /// <param name="removed"></param>
        static void RemoveWord(string path, string removed)
        {
            string fromFile = ReadText(path);

            string[] words = fromFile.Split(" ");

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i] == removed)
                {
                    words[i] = "";
                }

                string newString = String.Join(" ", words);
                File.WriteAllText(path, newString);
            }
        }


        /// <summary>
        /// Prompt user for input to make a word
        /// Call the length getter
        /// </summary>
        static void ChallengeNine()
        {
            Console.WriteLine("Enter a sentence: ");
            string input = Console.ReadLine();

            string[] output = GetLength(input);

            foreach (string word in output)
            {
                Console.WriteLine($"{word}");
            }
        }



        public static string[] GetLength(string sentence)
        {
            string[] splitString = sentence.Split(" ");

            for (int i = 0; i < splitString.Length; i++)
            {
                int wordLength = splitString[i].Length;
                splitString[i] = $"{splitString[i].ToLower()}: {wordLength}";
            }

            return splitString;
        }



    }


}








