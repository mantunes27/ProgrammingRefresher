using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This a programming refresher
// Exercises are in https://adriann.github.io/programming_problems.html

namespace ProgrammingRefresher
{
    public class ElementaryExercises
    {
        public int addition(int i, int x)
        {
            return i + x;
        }
        /*
        static void Main(string[] args)
        {
               //Elementary

               //1 print Hello World
               string hello = "Hello world";
               Console.WriteLine(hello);

               //2 get user name and greet him
               Console.WriteLine("What is your name?");
               string name = Console.ReadLine();
               //Different ways of adding string variables to a print in C#
               Console.WriteLine("Hello " + name);
               Console.WriteLine($"Hello {name}");
               Console.ReadLine();

               //3 Same as exercice 2 but only Alice and Bob can be greeted
               Console.WriteLine("What is your name?");
               string authName = Console.ReadLine();

               if (authName == "Bob" || authName == "Alice")
               {
                   Console.WriteLine($"Hello {authName}");
                   Console.ReadLine();
               }
               else
               {
                   Console.WriteLine("Not authorised");
                   Console.ReadLine();
               }

               //4 Program that asks the user for a number and prints the sum of the numbers 1 to n
               Console.WriteLine("Type a number");
               int n = Convert.ToInt32(Console.ReadLine());
               int total = 0;

               for (int i = 1; i <= n; i++)
               {
                   total += i;
               }

               Console.WriteLine(total);
               Console.ReadLine();

               //5 same as above but only multiples of 3 and 5 are considered in the total
               Console.WriteLine("Type a number");
               n = Convert.ToInt32(Console.ReadLine());
               total = 0;

               for (int i = 1; i <= n; i++)
               {
                   if (i % 5 == 0 || i % 3 == 0)
                   {
                       total += i;
                   }
               }

               Console.WriteLine(total);
               Console.ReadLine();

               //6 is similar to 4 but user gets to choose if he wants to sum or multiply
               Console.WriteLine("Do you want to add or multiply?Type add for addition or mult for multiplication");
               string addOrMult = Console.ReadLine();

               Console.WriteLine("Type the number you want to add or multiply");
               n = Convert.ToInt32(Console.ReadLine());
               total = 0;

               if (addOrMult == "add")
               {
                   for (int i = 1; i <= n; i++)
                   {
                       total += i;
                   }

                   Console.WriteLine(total);
                   Console.ReadLine();

               }
               else if (addOrMult == "mult")
               {
                   for (int i = 1; i <= n; i++)
                   {
                       total *= i;
                   }

                   Console.WriteLine(total);
                   Console.ReadLine();
               }
               else
               {
                   Console.WriteLine("Invalid command");
                   Console.ReadLine();
               }

               //7 Program that prints a multiplication table for numbers up to 12.

               //       for (int q = 1; q <= 12; q++)
               //       {
               //           for (int i = 1; i <= 10; i++)
               //           {
               //               Console.WriteLine(i * q);
               //           }
               //       }
               //       Console.ReadLine();

               //8 Prime numbers loop
               bool isPrime = true;
               Console.WriteLine("Prime Numbers : " );
               for (int i = 2; i <= 100; i++)
               {
                   for (int j = 2; j <= 100; j++)
                   {
                       if (i != j && i % j == 0)
                       {
                           isPrime = false;
                           break;
                       }
                   }
                   if (isPrime)
                   {
                       Console.WriteLine("\t" +i);
                   }
                   isPrime = true;
               }



               //9 Write a guessing game where the user has to guess a secret number. 
               //After every guess the program tells the user whether their number was too large or too small.
               //At the end the number of tries needed should be printed.
               //I counts only as one try if they input the same number multiple times consecutively.
               Console.WriteLine("Guesssing game!");
               Random rnd = new Random();
               int secretNumber = rnd.Next(1, 1000);
               var type = secretNumber.GetType();
               int numberOfGuesses = 0;
               List<int> guessedNumbers = new List<int>();

               bool guessed = true;

               while(guessed)
               {
                   Console.WriteLine("Guess the secret number!Type it!");
                   string guess = Console.ReadLine();
                   int number = Convert.ToInt32(guess);


                   if (secretNumber == number )
                   {
                       Console.WriteLine("That's the right number!");
                       guessed = true;
                       break;
                   }
                   else if (number.GetType() != type)
                   {
                       Console.WriteLine("That's not an int!");
                   }
                   else if(secretNumber != number )
                       {
                           if (number > secretNumber)
                           {
                               Console.WriteLine("Our guess was too high!");
                           }else
                           {
                           Console.WriteLine("Your guess was too low!");
                           }
                           if (!guessedNumbers.Contains(number))
                           {
                           guessedNumbers.Add(number);
                           numberOfGuesses += 1;
                           }

                       }
               }

               Console.WriteLine("You guessed " + numberOfGuesses + " times.");
               Console.ReadLine();
               
            //10 Write a program that prints the next 20 leap years.
            DateTime currentYear = new DateTime(2017,2,3);
            Console.WriteLine(currentYear);
            Console.ReadLine();

            int count = 0;
            for (int i = 0; i < 20; i++)
            {
                DateTime nextYear = new DateTime(2017 + count, 2, 3);
                int nextYearInt = nextYear.Year;
                count += 1;

                if(DateTime.IsLeapYear(nextYearInt))
                {
                    Console.WriteLine("{0} is a leap year.", nextYearInt);
                }
            }

            Console.ReadLine();
        }
        */
    }
}

