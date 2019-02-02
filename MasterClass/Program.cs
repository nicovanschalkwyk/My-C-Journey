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
    public static class MyStaticClass
    {
        public static int myStaticVariable = 10;

        public static void MyStaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }

        public static int MyStaticProperty { get; set; }
    }
    public class DemoTwo
    {

        static void Main(string[] args)
        {
            int nonStaticVariable = MyStaticClass.myStaticVariable;

            Console.WriteLine(nonStaticVariable);

            MyStaticClass.MyStaticMethod();

            MyStaticClass.MyStaticProperty = 100;

            Console.WriteLine(MyStaticClass.MyStaticProperty);
        }

        /*   public override string ToString() -- it overides the default value of tostring for the object.   which in this case would have been snakegame.Point but not is x: ...
            {
            return "x:" + x + ",y" + y;
            }
        */
        public static void WhoDatDog()
        {
            List<Dog> Neilsdogs = new List<Dog>();
            Dog JimDog = new Dog("Maxiepoof", 6);  // SAME AS 
            Neilsdogs.Add(JimDog);

            Neilsdogs.Add(new Dog("Hoover", 12));  // THIS
            Neilsdogs.Add(new Dog("Haley", 6));
            Neilsdogs.Add(new Dog("MaxiePoofm", 5));
        }

        public static void writeSomething()
        {
            Console.WriteLine("I am called from a method");
            Console.ReadLine();
        }

        //When you create a method, you create parameter. 
        //When you call method what you hand over is argument

        public static void writeSomethingSpecific(string myText) //Parameters and Arguments
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

        public static string Greetings(string name)
        {
            string result = ("Hi " + name + " my friend !!");
            return result;
        }//EXERCISE 1

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
        }//USER INPUT

        public static void TryCatch()  // TRY CATCH AND FINALLY
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

        public static void SmoothOperators()  //OPERATORS
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

            Console.WriteLine("if the ++ symbols are post variable, that variable will only increase next line", num4++);
            Console.WriteLine("num4 now = 4, if you want it to increase on the same line declared ++ pre variable", ++num4);

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

        public static void RegisterLogin() //REGISTER AND LOGIN CONSOLE
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

        public static void DetermineHighScore(int Score, string PlayerName) //DETERMINE HIGH SCORE
        {
            string HighScoreHolder = "Playa Playa";
            int HighScore = 10;

            if (Score > HighScore)
            {
                Console.WriteLine("New highscore is " + Score + " New highscore holder is " + PlayerName);
            }
            if (Score == HighScore)
            {
                Console.WriteLine("Your score equels the current Record " + HighScore + " Held by " + HighScoreHolder);
            }
            else if (Score < HighScore)
            {
                Console.WriteLine("The old highscore of " + HighScore + " could not be broken and is still held by " + HighScoreHolder);
            }

        }

        public static void KeyboardInput() //KEYBOARD INPUT - Move 0 AROUND USING ARROWS 
        {
            int X = 5;
            int Y = 4;

            //  XXXXXX   XXXXXX
            //  XXXXXX   XXXXXX
            //  XXXXXX   XXXXXX
            //  XXXXXX   XXXX0X
            //  XXXXX0   XXXXXX


            bool running = true;
            ConsoleKey consoleKey; //How to create when key is created if statement is saying if console.key == is Left Arrow 

            while (running)
            {
                consoleKey = Console.ReadKey().Key;

                if (consoleKey == ConsoleKey.Escape)
                {
                    running = !running;
                }
                else if (consoleKey == ConsoleKey.LeftArrow)
                {
                    Y = Y - 1;
                }
                else if (consoleKey == ConsoleKey.RightArrow)
                {
                    Y = Y + 1;
                }
                else if (consoleKey == ConsoleKey.UpArrow)
                {
                    X = X - 1;
                }
                else if (consoleKey == ConsoleKey.DownArrow)
                {
                    X = X + 1;
                }

                Console.Clear();

                for (int row = 0; row < 6; row++)
                {
                    for (int column = 0; column < 6; column++)
                    {
                        if (row == X && column == Y)
                        {
                            Console.Write("0 ");
                        }
                        else
                            Console.Write("X ");
                    }

                    Console.WriteLine();
                }
            }
        }

        public static void leftArrow()
        {
            for (int i = 1; i < 6; i++)
            {

                for (int x = 5; x > i; x--)
                {
                    Console.Write("X");
                }

                for (int s = 0; s < i; s++)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

            for (int i = 1; i < 6; i++)
            {
                for (int x = 1; x < i; x++)
                {
                    Console.Write(" ");
                }

                for (int s = 6; s > i; s--)
                {
                    Console.Write("X");
                }
                Console.WriteLine();
            }

        }//lEFT ARROW USING FOR LOOP

        public static void printmethod3()//SIDE ARROW USING FOR LOOP                    
        {                                                                 //  X 
            for (int i = 1; i < 6; i++) //manages lines/rows              //  XX
            {                                                             //  XXX             
                for (int y = 0; y < i; y++)                               //  XXXX
                {                                                         //  XXXXX
                    Console.Write("x"); //manages values                  //  XXXX           
                }                                                         //  XXX       
                Console.WriteLine();                                      //  XX
            }                                                             //  X  

            for (int i = 6; i > 0; i--)
            {
                for (int x = 0; x < i; x++)
                {
                    Console.Write("x");
                }
                Console.WriteLine();
            }
        }

        public static void SwitchAndCase()
        {
            int age = 0;

            switch (age)  //Switch and Finally COMPARE VALUE TO A NUMBER OF VALUES
            {
                case 18:                                             //if values are the same = code executed
                    Console.WriteLine("Old Enough for da Club");
                    break;
                case 16:
                    Console.WriteLine("Old enough to get you in Jail");
                    break;
            }
        }

        public static void LoopsMasterClassChallenge() //Student Score Average
        {
            bool running = true;
            List<int> studentScores = new List<int>();

            while (running)
            {
                Console.WriteLine("Enter sudent score: ");
                try
                {
                    int input = int.Parse(Console.ReadLine());
                    studentScores.Add(input);
                    if (input < 0)
                    {
                        break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("You did not enter a number please try again");
                }
            }

            Console.WriteLine("The average score for all student scores entered is " + studentScores.Average());
            Console.ReadLine();
        }

        public static void EnhancedIfStatements()
        {
            //If statement (without brackets)
            int temp = -5;
            string stateOfMatter;

            if (temp < 0)
                stateOfMatter = "Its cold";
            else
                stateOfMatter = "Its could be colder";

            Console.WriteLine("The state of matter is {0}", stateOfMatter);

            //Enhanced (Same as above)
            stateOfMatter = temp < 0 ? "It's Cold" : "It coudl be Colder"; // ? = IF it's true ----- 1st code following = executed if true ----- last code = executed if not
            Console.WriteLine("The state of matter is {0}", stateOfMatter);
            Console.ReadKey();

        }

        //  Create Class - Dog Type, Colour (properties) - call must be able to type add - ask what type what colour, List - give you list of dogs that have been captured
        //  you can have a list of objects which have different data types - list of objects with different data types (parameter int, string) - this what program must have
        //  Die aanhouer wen
    }

    public class Dog
    {
        public string name;
        public int age;

        public Dog(string Name, int Age)
        {
            name = Name;
            age = Age;
        }

        public override string ToString()
        {
            return name;
        }
        //  public void newDog(string name, int age)   //City - Hospital - Departments - Rooms - Patients - Condition each of/some of/but everyone has atleas one property/properties (of potentially different data types)
        //  They all have/could have method/methods - in this case the 1st two simple be lists with a list - list of cities , in each city a list of hospitals - each hospital has departments
        //  then look at departments type of data you receive from them - financial (int) which would be based on method (income vs expenses), type of personnel (string), another list patients each patient has property - condition  
        //  
    }

    public static class AddDog
    {
        public static List<Dog> WhoDatDog()
        {
            List<Dog> Neilsdogs = new List<Dog>();

            Dog JimDog = new Dog("Maxiepoof", 6);  // SAME AS 
            Neilsdogs.Add(JimDog);

            Neilsdogs.Add(new Dog("Hoover", 12));  // THIS
            Neilsdogs.Add(new Dog("Haley", 6));
            Neilsdogs.Add(new Dog("MaxiePoofm", 5));

            return Neilsdogs;
        }
    }

    public class Human
    {
        //Member Variable
        public string firstname;
        public string lastname;
        public string eyecolour;
        public int age;

        //Parameterized Constructor
        public Human(string firstName, string lastName, string eyeColour, int Age)
        {
            this.firstname = firstName;
            this.lastname = lastName;
            this.eyecolour = eyeColour;
            this.age = Age;
        }

        public Human(string firstName, string lastName)
        {
            this.firstname = firstName;
            this.lastname = lastName;
        }

        public Human(string firstName)
        {
            this.firstname = firstName;
        }

        //member method
        public void IntroduceMyself()
        {
            if (age != 0 && lastname != null && eyecolour != null && firstname != null)
            {
                Console.WriteLine("Hi i am {0} {1} , i am {2} years old and i have {4} colour eyes ", firstname, lastname, age, eyecolour);
            }
            else if (age == 0 && firstname != null && lastname != null && eyecolour == null)
            {
                Console.WriteLine("Hi i am {0} {1} ", firstname, lastname);
            }
            else if (age == 0 && firstname != null && lastname == null && eyecolour == null)
            {
                Console.WriteLine("Hi i am {0} ", firstname);
            }
        }



    }

    public static class EnumerableExtension
    {
        public static T PickRandom<T>(this IEnumerable<T> source)
        {
            return source.PickRandom(1).Single();
        }

        public static IEnumerable<T> PickRandom<T>(this IEnumerable<T> source, int count)
        {
            return source.Shuffle().Take(count);
        }

        public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source)
        {
            return source.OrderBy(x => Guid.NewGuid());
        }
    }

    public class Person
    {
        static public string name;
        static public string surname;
        static public int salary;

        static Person()
        {

        }

        public static List<string> Names = new List<string>() { "George", "Dick", "Sadam", "Jimmy", "Mr R" };
        public static List<string> Surnames = new List<string>() { "Cheney", "SoInnocent", "Washington" };


        public static Person operator -(Person p)
        {
            Person.name = Names.PickRandom();
            Person.surname = Surnames.PickRandom();
            Person.salary = salary + salary;
        }
    }
    // human - name surname salary - bob + jim (sum salary) create new person (random name, random surname)
    // lists for names & surnames - choose randomly from those


}


