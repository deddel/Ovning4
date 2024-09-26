using System;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>
        static void Main()
        {

            while (true)
            {
                Console.WriteLine("\nPlease navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            //Create a list
            List<string> theList = new List<string>();

            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */
            
            bool examineListIsRunning = true;
            
            while (examineListIsRunning)
            {
                //Submenu - ExamineList
                Console.WriteLine("\nList Menu. Navigate by inputting (1, 0)"
                + "\n1. Add or remove from the list"
                + "\n2. Show list stats"
                + "\n0. Exit to the Main Menu");
                string input = Console.ReadLine();
                char nav = input[0];
                bool addingItems = true;

                switch (nav) 
                {
                    case '0':
                        examineListIsRunning = false;
                        break;
                    case '1':
                        Console.WriteLine("Start your input with + or - followed by the list item to be added or removed");
                        Console.WriteLine("Start your input with 0 to exit to the ExamineList nenu");
                        while (addingItems)
                        {
                            string inputString = Console.ReadLine();
                            char addOrRemove = inputString[0];
                            //string addOrRemoveString = inputString.Substring(1);
                            if (addOrRemove == '+')
                            {
                                theList.Add(inputString.Substring(1));
                                Console.WriteLine($"List Count: {theList.Count}");
                                Console.WriteLine($"List Capacity: {theList.Capacity}");
                            }
                            else if (addOrRemove == '-')
                            {
                                theList.Remove((inputString.Substring(1)));
                                Console.WriteLine($"theList.Count: {theList.Count} \ttheList.Capacity: {theList.Capacity}");
                            }
                            else if (addOrRemove == '0')
                            {
                                addingItems = false;
                            }
                            else
                            {
                                Console.WriteLine("Please enter some valid input (+Item, -Item or 0");
                            }
                        }
                        break;
                    case '2':
                        Console.WriteLine($"theList.Count: {theList.Count}");
                        Console.WriteLine($"theList.Capacity: {theList.Capacity}");
                        foreach (var item in theList)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2)");
                        break;
                }

            }
            
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

        }

    }
}

