using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace MasterClass//VOID METHOD DEMO

//{
//    class Program 
//    {
//        static void Main(string[] args)
//        {
//            writeSomething();
//            writeSomethingSpecific("i am an argument");
//            Console.Read();
//        }

//        public static void writeSomething()// returns parameter + parameter
//        {
//            Console.WriteLine("i am called from a method");
//        }

//        public static void writeSomethingSpecific(string text)
//        {
//            Console.WriteLine(text);
//        }
//    }
//}
namespace Masterclass
{
    class DemoTwo
    {
        static void Main(string[] args)
        {
            /*int result = Add(3, 3);    //Take note here, i had create variable and THEN call method

            Add(Add(3, 3), Add(2, 2));  //The method is equel to the return value itself - add = 6, add = 4

            Console.WriteLine(Calculate()); //- return type = int calculation
                                            //Calculate(); - return type = void*/
            RegisterLogin();
        }

        public static void writeSomething()
        {
            Console.WriteLine("I am called from a method");
            Console.ReadLine();
        }

        //When you create a method, you create parameter. 
        //When you call method what you hand over is argument

        public static void writeSomethingSpecific(string myText)
        {
            Console.WriteLine(myText);
            Console.Read();
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        //EXERCISE 1
        public static string Greetings(string name)
        {
            string result = ("Hi " + name + " my friend !!");
            return result;
        }

        //USER INPUT
        public static int Calculate()
        {
            Console.WriteLine("Enter a Number: "); //Take note how two seperate user inputs are stored here
            string num1 = Console.ReadLine();

            Console.WriteLine("Enter another Number: ");
            string num2 = Console.ReadLine();

            int conNum1 = int.Parse(num1);        //Two different ways to convert string to int
            int conNum2 = Convert.ToInt32(num2);

            int calculation = conNum1 * conNum2;

            return calculation;// - this will enable to use .Writeline with method in main, see green in main

            //Console.WriteLine(calculation); // - this enables the method to just be called 
        }

        //Try Catch & Finally
        public static void TryCatch()
        {

            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
                                                    //Can Set different code to run, for various errors
            try
            {
                /*int inputCon = int.Parse(input)*/
                int? userInput = 10;               //Using Null ? after data type
            }
            catch (FormatException)
            {
                Console.WriteLine("String was not in correct format, to parse into int");
            }
            catch (OverflowException)        
            {
                Console.WriteLine("The input was too short or too long , for int32");
            }
            catch (ArgumentNullException)        
            {
                Console.WriteLine("Input was empty");
            }
            finally
            {
                Console.WriteLine("Code block here will execute regardless");
                //Example - you try download from location  - does not work (error) want to close connection afterwards
                //Exampe - want to write to file - cannot (error) , need to close opened file afterwards regardless
            }
        }

        //Operators
        public static void SmoothOperators()
        {
            bool raining = true;
            bool sunny = true;

            int num1 = 2;
            int num2 = 4;
            int num3;

            //Unary operators
            num3 = -num2;                //Multiplies variable with negative 4(num2) - note variable (num2) is positive

            //Negate - cause opposite value
            bool sunshining = true;
            Console.WriteLine(!sunshining);

            //Increment Operator   *Variable incremented following line*
            int num4 = 1;
            num4++;

            //Decrement            *Variable is decremented(value changes), following line*
            int num5 = 1;
            num5--;

            //Pre Increment        *Variable is incremented(value changes) on sameline(as it is written)*
            int num6 = 1;
            ++num6;

            //Pre Decrement        *Variable in decremented on same line*
            int num7 = 1;
            --num7;

            Console.WriteLine("if the ++ symbols are post variable, that variable will only increase next line" , num4++);
            Console.WriteLine("num4 now = 4, if you want it to increase on the same line declared ++ pre variable" , ++num4);

            //TAKE NOTE - when variable values is changed depending on type of increment or decrement operator used
            //Example - for loop, can not declare loop control variable, ++/-- in block - affect flow possibly in desired way

            //Modulo Operator
            int num8 = 5 % 2; //Remainder of 
            Console.WriteLine(num8);

           //Relational & Type Operators

            //IS LOWER THAN
           bool smallerThan = 3 < 4;      //3 smaller than 4

            //BIGGER THAN
            bool biggerThan = 3 > 4;

            //EQUEL TO 
            bool isThisTrue = smallerThan == biggerThan;

            //AND 
            bool theWeatherIsFkinWeird = raining && sunny; //its raining && sunny

            //OR
            bool theWeatherIsUnknown = raining || sunny; //it'g going to rain OR be a sunny day
        }

        public static void MakingDecisions()  //IF STATEMENTS
        {
            string userNumber = Console.ReadLine();

            try
            {
                int temperature = int.Parse(userNumber);

                if (temperature > 0) //Greater than - Above Zero degrees Celsius
                {
                    Console.WriteLine("This code is executed if the 1st condition is met (true)");
                }
                else if (temperature < 0) //Smaller than - Below Zero degrees Celsius
                {
                    Console.WriteLine("This Condition is checked if the first condition was not true");
                }
                else
                {
                    Console.WriteLine("This code executes, if both the 1st and 2nd conditions were not true");
                }
                //  TAKE NOTE
                //  This is a good example the showcase, decision making - how to use if statements ?
                //  In this case the temperature is either above or below zero if it's neither (universe collapses?)
                //  The else statement's code is executed
                //  I could just have 3 seperate if statements, which would be fine except unecessary processing power
                //  and ram is being used to run through that code, given the situation and the assessment - above or below ?
                //  A if, if else and else format is correct choice

                // Think of the above example when your refactoring, or reviewing your code.
            }
            catch (Exception)
            {
                Console.WriteLine("Please enter a number");
            }
        }

        public static void isRegistered()
        {
            bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";

            Console.WriteLine("Enter username");

            userName = Console.ReadLine();

            if (isRegistered && userName != "" && userName.Equals("admin"))
            {
                Console.WriteLine("Registered User");

                Console.WriteLine("Hi there, " + userName);

                Console.WriteLine("Hi there, Admin");
            }
            Console.Read();
        }

        public static void RegisterLogin()
        {
            string user = "Jeff";
            string password = "1969";

            Console.WriteLine("Please enter a username: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Enter a password to complete the registration process, you will be automatically logged in: ");
            string Password = Console.ReadLine();

            if (userName == user)
            {
                if (Password == password)
                {
                    Console.WriteLine("Welcome Jeff");
                }
                else
                    Console.WriteLine("Incorrect username and/or Password");
            }
           
        }
    }
}


