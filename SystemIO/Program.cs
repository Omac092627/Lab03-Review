﻿using System;
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
                isFormatted = callBack(arraySize);
            }
            else
            {
                Console.WriteLine("Improper input, try again.");
                isFormatted = true;
            }

        } while (isFormatted);

    }

    ///Method for negative number on above method///
    public static bool callBack(int arraySize)
    {
        bool isFormatted = false;
        try
        {
            int[] methodArray = new int[arraySize];
            for(int i = 0; i < methodArray.Length; i++)
            {
                Console.WriteLine($"{i + 1} of {methodArray.Length} - Enter a number: ");
                int inputNumber = Convert.ToInt32(Console.ReadLine());
                if(inputNumber >= 0)
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
            if(isFormatted == false)
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

        for(int i = 0; i < inputArray.Length; i++)
        {
            sum += inputArray[i];
        }

        decimal sumDecimal = Convert.ToDecimal(sum);
        decimal lengthDecimal = Convert.ToDecimal(inputArray.Length);
        decimal average = sumDecimal / lengthDecimal;

        return average;
    }



















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

    public static int ChallengeFive(int[] array)
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


    /// <summary>
    /// Promopt the user to enter a sentence
    /// String the words the user enters
    /// String an array in order to split up the char's
    /// String a counter in order to count the number of char's in word
    /// For loop to loop through the array
    /// Call the count method while looping through entered array and set equal to concatanation
    /// Return value to user
    /// </summary>
    static void GetLengthOfEachWord()
    {
        Console.WriteLine("PLEASE ENTER A SENTENCE:");
        string words = Console.ReadLine();
        string[] wordsArray = words.Split(" ");
        string[] count = new string[wordsArray.Length * 2];


        for (int i = 0; i < wordsArray.Length; i++)
        {
            count[i] = ($"{String.Join(',', wordsArray[i])}: {String.Join(',', wordsArray[i].Length)}");
        }
        Console.WriteLine(count);

    }


}

}



