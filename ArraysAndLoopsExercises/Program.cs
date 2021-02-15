using System;

namespace ArraysAndLoopsExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepThinking = true;
            while (keepThinking)
            {
                Console.Clear();
                Console.WriteLine("ARRAYS AND LOOPS EXERCISES\n");
                Console.WriteLine("Which exercise would you like to run?");
                Console.WriteLine("1. Sort the Numbers");
                Console.WriteLine("2. Which Day of the Week?");
                Console.WriteLine("3. Find the Smallest Number in an Array");
                Console.WriteLine("4. Shopping List");
                Console.WriteLine("5. What's the Longest Word?");
                Console.WriteLine("6. What's the Second to Last Word?");
                Console.WriteLine("7. Print a Triangle");
                Console.WriteLine("8. Common Values");
                Console.WriteLine("Press Q to quit");

                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        SortTheNumbers();
                        break;
                    case "2":
                        WhichDayOfWeek();
                        break;
                    case "3":
                        SmallestNumberInArray();
                        break;
                    case "4":
                        ShoppingList();
                        break;
                    case "5":
                        LongestWord();
                        break;
                    case "6":
                        SecondToLastWord();
                        break;
                    case "7":
                        PrintTriangle();
                        break;
                    case "8":
                        CommonValues();
                        break;
                    case "q":
                        keepThinking = false;
                        Console.WriteLine("Good bye!");
                        break;
                    default:
                        break;
                }
            }
        }

        static void SortTheNumbers()
        {
            // Ask 10 people for their favorite numbers and create an array of those numbers. 
            // Order the numbers using the sort method. Print the first and last numbers.

            Console.Clear();
            Console.WriteLine("SORT THE NUMBERS\n");

            // Enter your solution here
            int[] favoriteNumbers = new int[10];
            for (int index = 0; index < favoriteNumbers.Length; index++)
            {
                Console.WriteLine("What is your favorite number?");
                int favoriteNumber = Convert.ToInt32(Console.ReadLine());
                favoriteNumbers[index] = favoriteNumber;
            }
            Array.Sort(favoriteNumbers);
            Console.WriteLine("The first number is: " + favoriteNumbers[0] + "\nThe last number is: " + favoriteNumbers[9]);

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void WhichDayOfWeek()
        {
            // Declare and initialize a string array with the 7 days of the week. 
            // Print the number corresponding to each day and the day of the week. (1 = Sunday, 2 = Monday, etc.)

            // Ask the user for a number between 1 - 7.
            // Print the day of the week that corresponds to the number
            
            Console.Clear();
            Console.WriteLine("WHICH DAY OF THE WEEK?\n");

            // Enter your solution here
            string[] daysOfWeek = new string[8] { "Zero", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" } ;
            for (int index = 1; index < daysOfWeek.Length; index++)
            {
                Console.WriteLine(index + " = " + daysOfWeek[index]);
            }
            Console.WriteLine("Choose a number between 1-7");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have chosen " + daysOfWeek[userNumber] + " as the day of the week.");

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SmallestNumberInArray()
        {
            // Ask the user for 5 integers and save them in an array. 
            // Find the smallest number in the array and write it to the screen.

            Console.Clear();
            Console.WriteLine("FIND THE SMALLEST NUMBER IN AN ARRAY\n");

            // Enter your solution here
            int[] userNumbers = new int[5];
            for (int index = 0; index < userNumbers.Length; index++)
            {
                Console.WriteLine("Please enter an integer: ");
                int userNumber = Convert.ToInt32(Console.ReadLine());
                userNumbers[index] = userNumber;
            }
            Array.Sort(userNumbers);
            Console.WriteLine("The smallest number is: " + userNumbers[0]);


            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }


        static void ShoppingList()
        {
            // Initialize an array with 4 food items. Print this shopping list to the console.

            Console.Clear();
            Console.WriteLine("SHOPPING LIST\n");

            // Enter your solution here
            string[] shoppingList = new string[4] { "Bread", "Tofu", "Tortillas", "Almond Milk" };
            for (int index = 0; index < shoppingList.Length; index++)
            {
                Console.WriteLine(shoppingList[index]);
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void LongestWord()
        {
            // Ask the user for a phrase consisting of 1-4 words (no punctuation).
            // Print the longest word in the phrase. If 2 words have the same length, print both.

            Console.Clear();
            Console.WriteLine("WHAT'S THE LONGEST WORD?\n");

            // Enter your solution here
            Console.WriteLine("Type a phrase of 1 to 4 words, no punctuation please.");
            string userPhrase = Console.ReadLine();
            string[] userWords = userPhrase.Split(' ');
            int[] userWordLengths = new int[4];

            for (int index = 0; index < userWords.Length; index++)
            {
                userWordLengths[index] = userWords[index].Length;
            }
            Array.Sort(userWordLengths);

            string[] sortedWords = new string[4];
            for (int index = 0; index < userWords.Length; index++)
            {
                if (userWordLengths[0] == userWords[index].Length && sortedWords[0] == null)
                {
                    sortedWords[0] = userWords[index];
                    continue;
                }
                if (userWordLengths[1] == userWords[index].Length && sortedWords[1] == null)
                {
                    sortedWords[1] = userWords[index];
                    continue;
                }
                if (userWordLengths[2] == userWords[index].Length && sortedWords[2] == null)
                {
                    sortedWords[2] = userWords[index];
                    continue;
                }
                if (userWordLengths[3] == userWords[index].Length && sortedWords[3] == null)
                {
                    sortedWords[3] = userWords[index];
                    continue;
                }
                else
                    continue;
            }
            
            if (sortedWords[2].Length == sortedWords[3].Length)
            {
                Console.WriteLine("The longest words are " + sortedWords[2] + " and " + sortedWords[3]);
            }
            else
                Console.WriteLine("The longest word is " + sortedWords[3]);






            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void SecondToLastWord()
        {
            // Ask the user for a sentence or phrase consisting of at least 4 words.
            // Find the second to last word and print it.

            Console.Clear();
            Console.WriteLine("WHAT'S THE SECOND TO LAST WORD?\n");

            // Enter your solution here
            Console.WriteLine("Type a phrase of at least 4 words, no punctuation please.");
            string userPhrase = Console.ReadLine();
            string[] userWords = userPhrase.Split(' ');

            string secondToLastWord = userWords[userWords.Length - 2];
            Console.WriteLine("The second to last word is " + secondToLastWord);

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void PrintTriangle()
        {
            // Ask the user for a number between 3 and 6. 
            // Print one asterisk to the screen. 
            // On the next line print 2 asterisks, and continue until the users number is reached.

            Console.Clear();
            Console.WriteLine("PRINT A TRIANGLE\n");

            // Enter your solution here
            Console.WriteLine("Please enter a number between 3 and 6");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            string[] triangle = new string[] { " ", "*", "**", "***", "****", "*****", "******" };
            for (int index = 0; index <= userNumber; index++)
            {
                Console.WriteLine(triangle[index]);
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        static void CommonValues()
        {
            // You are given 3 arrays of the same size, where 1 is empty and 2 have values. 
            // Use nested loops to find the values that are common between the 2 arrays.

            Console.Clear();
            Console.WriteLine("COMMON VALUES\n");

            // Enter your solution here
            string[] arrayOne = new string[3] { null, null, null };
            string[] arrayTwo = new string[3] { "1", "2", "3" };
            string[] arrayThree = new string[3] { "2", "3", "4" };

            for (int index = 0; index <= 2; index++)
            {
                if (arrayTwo[index] == arrayThree[0])
                {
                    arrayOne[index] = arrayThree[0];
                }
                if (arrayTwo[index] == arrayThree[1])
                {
                    arrayOne[index] = arrayThree[1];
                }
                if (arrayTwo[index] == arrayThree[2])
                {
                    arrayOne[index] = arrayThree[2];
                }
                else
                    continue;
            }
            Console.WriteLine("The first set of values are: ");
            for (int index = 0; index < arrayTwo.Length; index++)
            {
                Console.WriteLine(arrayTwo[index]);
            }

            Console.WriteLine("The second set of values are: ");
            for (int index = 0; index < arrayThree.Length; index++)
            {
                Console.WriteLine(arrayThree[index]);
            }
            Console.WriteLine("The common values are: ");
            for (int index = 0; index < arrayOne.Length; index++)
            {
                Console.WriteLine(arrayOne[index]);
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

    }
}


