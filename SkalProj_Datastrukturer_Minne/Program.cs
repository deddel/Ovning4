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
                Console.WriteLine("Main Menu - data structures and memory");
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
                        Console.WriteLine("Start your input with 0 to exit to the List nenu");
                        while (addingItems)
                        {
                            string inputString = Console.ReadLine();
                            
                            char addOrRemove = inputString[0];//TODO: fix crash on empty input
                            //string addOrRemoveString = inputString.Substring(1);
                            if (addOrRemove == '+')
                            {
                                theList.Add(inputString.Substring(1));
                                Console.WriteLine($"Count: {theList.Count} \tCapacity: {theList.Capacity}");
                            }
                            else if (addOrRemove == '-')
                            {
                                theList.Remove((inputString.Substring(1)));
                                Console.WriteLine($"Count: {theList.Count} \tCapacity: {theList.Capacity}");
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
                        Console.WriteLine($"Count: {theList.Count} \tCapacity: {theList.Capacity}");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Items in the list: {string.Join(",", theList)}");
                        Console.ResetColor();
                        Console.WriteLine();
                        //foreach (var item in theList)
                        //{
                        //    Console.WriteLine(item);
                        //}
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
            Queue<string> queue = new Queue<string>();
            bool examineQueueIsRunning = true;

            while (examineQueueIsRunning)
            {
                //Submenu - ExamineQueue

                Console.WriteLine("\nQueue Menu. Navigate by inputting (1, 2, 0)"
                + "\n1. Add customers to the queue"
                + "\n2. Remove item from the queue"
                + "\n0. Exit to the Main Menu");
                string input = Console.ReadLine();
                char nav = input[0]; //TODO fix crash on empty
                switch (nav)
                {
                    case '1':
                        Console.Write("Input customer to enqueue: ");
                        string inputString = Console.ReadLine();
                        queue.Enqueue(inputString);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Customers in the queue: {string.Join(",", queue)}");
                        Console.ResetColor();
                        break;
                    case '2':
                        queue.Dequeue();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Customers in the queue: {string.Join(",", queue)}");
                        Console.ResetColor();
                        break;
                    case '0':
                        examineQueueIsRunning = false;
                        break;
                    default:
                        Console.WriteLine("Please enter a valid input (0,1,2)");
                        break;


                }
            }
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
            Stack<char> stack = new Stack<char>();
            string inputString = "";
            bool examineStackIsRunning = true;
            while (examineStackIsRunning)
            {
                Console.WriteLine("\nStack Menu. Navigate by inputting (0, 1, 2, 3, 4)"
                     + "\n1. Input a string and add the characters to a stack"
                     + "\n2. Push characters to the stack"
                     + "\n3. Pop characters from the stack"
                     + "\n4. Reverse a string"
                     + "\n0. Exit to the Main Menu");
                string input = Console.ReadLine();
                char nav = input[0]; //TODO fix crash on empty

                switch (nav)
                {
                    case '1':
                        Console.Write("Input a string: ");
                        inputString = Console.ReadLine();
                        if (inputString != "" || inputString != null)
                        {
                            foreach (char c in inputString!)
                            {
                                stack.Push(c);
                            }
                            Console.Write("The stack now contains: ");
                            foreach (char c in stack)
                            {
                                Console.Write(c);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Empty string");
                        }
                        break;
                    case '2':
                        Console.Write("Input a character: ");
                        string inputStr = Console.ReadLine();
                        char ch = inputStr[0];
                        stack.Push(ch);
                        Console.Write("Stack contains: ");
                        foreach (char c in stack)
                        {
                            Console.Write(c);
                        }
                        break;
                    case '3':
                        if (stack.TryPop(out char res))
                        {
                            Console.Write($"Removed {res}, Stack now contains: ");
                            foreach (char c in stack)
                            {
                                Console.Write(c);
                            }
                        }
                        else
                        {
                            Console.WriteLine("The Stack is empty");
                        }
                        break;
                    case '4':
                        ReverseText();

                        break;

                    case '0':
                        examineStackIsRunning = false;
                        break;

                }


            }
        }

        /// <summary>
        /// ReverseText
        /// </summary>
        static void ReverseText()
        {
            Stack<char> stk = new Stack<char>();
            string str = "";
            string inputString = "";
            Console.Write("Input a string: ");
            inputString = Console.ReadLine();
            if (inputString != "" || inputString != null)
            {
                foreach (char c in inputString!)
                {
                    stk.Push(c);
                }
                Console.Write("Reversed text: ");
                foreach (char c in stk)
                {
                    str += c;
                }
                Console.WriteLine(str);
            }
            else
            {
                Console.WriteLine("Empty string");
            }
        }
        /// <summary>
        /// CheckParanthesis
        /// </summary>
        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */
            string correctString1 = "(()), {}, [({})]"; //Correct
            string correctString2 = "List<int> list = new List<int>() { 1, 2, 3, 4 }"; //Correct
            string incorrectString1 = "(()]), [), {[()}]"; //Incorrect
            string incorrectString2 = "List<int> list = new List<int>() { 1, 2, 3, 4 )"; //Incorrect
            string emptyString = "";
            string nullString = null;
            string inputString = correctString1;
            //string inputString = null;
            Stack<char> stk = new Stack<char>();
            //Console.WriteLine(emptyString == "");
            //Console.WriteLine(inputString == "");
            //Console.WriteLine(inputString == null);

            //Console.WriteLine(inputString != "");

            //Console.WriteLine(inputString != null);



            //if (inputString != "" && inputString != null)
            if (!String.IsNullOrWhiteSpace(inputString))
                {
                bool isWellFormed = true;
                foreach (char c in inputString!)
                {
                    if (c == '(' || c == '{' || c == '[')
                    {
                        stk.Push(c);
                    }
                    else if (c == ')' || c == '}' || c == ']')
                    {
                        if (stk.Count == 0)
                        {
                            isWellFormed = false;
                            break;
                        }
                        else if (c == ')' && stk.First() == '(')
                        {
                            stk.Pop();
                        }
                        else if (c == '}' && stk.First() == '{')
                        {
                            stk.Pop();
                        }
                        else if (c == ']' && stk.First() == '[')
                        {
                            stk.Pop();
                        }
                        else if (c != stk.First())
                        {
                            isWellFormed = false;
                            break;
                        }
                    }
                }
                if (isWellFormed)
                {
                    Console.WriteLine("The string is well formed");
                }
                else
                {
                    Console.WriteLine("The string is not well formed");
                }
            }
            else 
            {
                Console.WriteLine("Empty string");
            }


        }

    }
}

