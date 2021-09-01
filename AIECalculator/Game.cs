using System;
using System.Collections.Generic;
using System.Text;

namespace AIECalculator
{
    class Game
    {
        string numOneInput;
        string numTwoInput;
        float numOne;
        float numTwo;
        bool numChecker;
        bool validInputRecieved = false;
        bool endApp = false;
        string userInput;

        public void Run()
        {
            Console.WriteLine("Console based calculator in C#.");
            Console.ReadKey();
            Console.Clear();

            while (!endApp)
            {
                //Loops until valid float is receieved by user
                validInputRecieved = false;
                while (!validInputRecieved)
                {
                    Console.WriteLine("Enter your first number.");
                    Console.Write("> ");
                    numOneInput = Console.ReadLine();

                    //Converts the input into a float
                    numChecker = float.TryParse(numOneInput, out numOne);
                    if (numChecker)
                    {
                        validInputRecieved = true;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter a valid number.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }


                //Loops until valid float is recieved by user
                validInputRecieved = false;
                while (!validInputRecieved)
                {
                    Console.Clear();
                    Console.WriteLine($"First number: {numOne}\n");
                    Console.WriteLine("Now, enter your second number.");
                    Console.Write("> ");
                    numTwoInput = Console.ReadLine();

                    //Converts the input into a float
                    numChecker = float.TryParse(numTwoInput, out numTwo);
                    if (numChecker)
                    {
                        validInputRecieved = true;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter a valid number.");
                        Console.ReadKey();
                    }
                }

                validInputRecieved = false;
                while (!validInputRecieved)
                {
                    Console.Clear();
                    Console.WriteLine($"Number one: {numOne}");
                    Console.WriteLine($"Number two: {numTwo}\n");


                    Console.WriteLine("What would you like to do with these numbers?");
                    Console.WriteLine("a - Add");
                    Console.WriteLine("b - Subract");
                    Console.WriteLine("c - Multiply");
                    Console.WriteLine("d - Divide\n");
                    Console.Write("> ");
                    userInput = Console.ReadLine().ToLower();

                    if ((userInput == "a") || (userInput == "add"))
                    {
                        handleMath("add");
                        validInputRecieved = true;
                    }

                    else if ((userInput == "b") || (userInput == "subtract"))
                    {
                        handleMath("subtract");
                        validInputRecieved = true;
                    }

                    else if ((userInput == "c") || (userInput == "multiply"))
                    {
                        handleMath("multiply");
                        validInputRecieved = true;
                    }

                    else if ((userInput == "d") || (userInput == "divide"))
                    {
                        handleMath("divide");
                        validInputRecieved = true;
                    }
                    else
                    {
                        Console.WriteLine("\nPlease enter a valid operator");
                        Console.ReadKey();
                    }

                }

                validInputRecieved = false;
                while (!validInputRecieved)
                {
                    Console.WriteLine("Would you like to use the calculator again?\n");
                    Console.WriteLine("a - Yes");
                    Console.WriteLine("b - No");
                    Console.Write("> ");
                    userInput = Console.ReadLine().ToLower();

                    if ((userInput == "a") || (userInput == "yes"))
                    {
                        endApp = false;
                        validInputRecieved = true;
                    }
                    else if ((userInput == "b") || (userInput == "no"))
                    {
                        Console.Clear();
                        Console.WriteLine("\nOkay then, have a nice day!");
                        Console.ReadKey();
                        endApp = true;
                        validInputRecieved = true;
                    }
                    else
                    {
                        Console.WriteLine("Please enter valid input!");
                    }
                }
            }
        }

        public void handleMath(string mathOperator)
        {
            if (mathOperator == "add")
            {
                Console.WriteLine($"\n{numOne} + {numTwo} = {numOne + numTwo}\n");
                Console.ReadKey();
            }

            if (mathOperator == "subtract")
            {
                Console.WriteLine($"\n{numOne} - {numTwo} = {numOne - numTwo}\n");
                Console.ReadKey();
            }

            if (mathOperator == "multiply")
            {
                Console.WriteLine($"\n{numOne} * {numTwo} = {numOne * numTwo}\n");
                Console.ReadKey();
            }

            if (mathOperator == "divide")
            {
                Console.WriteLine($"\n{numOne} / {numTwo} = {numOne / numTwo}\n");
                Console.ReadKey();
            }
        }
    }
}
