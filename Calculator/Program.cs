using System.Linq.Expressions;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the calculator app!");
            Console.WriteLine("What type of calculation do you want to perform? (+, -, * or /) ");
            string calcType = "";
            string firstNumberString = "";
            string secondNumberString = "";
            double firstNumber = 0;
            double secondNumber = 0;

            while(true)
            {
                calcType = Console.ReadLine();

                if(calcType == "+" || calcType == "-" || calcType == "*" || calcType == "/")
                {
                    Console.WriteLine("Your selected sign is: " + calcType);
                    break;
                }
                Console.Error.WriteLine("You entered invalid input. Please enter one of these signs: (+, -, * or /) !");
            }

            while(true)
            {
                Console.WriteLine("Please write the first number. (Between -1000.0 and 1000.0 for test reasons.)");
                firstNumberString = Console.ReadLine();

                if(double.TryParse(firstNumberString, out firstNumber))
                {
                    if(firstNumber >= -1000 && firstNumber <= 1000)
                    {
                        Console.WriteLine("Your first number is: " + firstNumber);
                        break;
                    }
                }
                Console.Error.WriteLine("You entered invalid input. Please enter a valid number! ");
            }

            while(true)
            {
                Console.WriteLine("Please write the second number. (Between -1000.0 and 1000.0 for test reasons.)");
                secondNumberString = Console.ReadLine();

                if(double.TryParse(secondNumberString, out secondNumber))
                {
                    if(secondNumber >= -1000 && secondNumber <= 1000)
                    {
                        Console.WriteLine("Your second number is: " + secondNumber);
                        break;
                    }
                }
                Console.Error.WriteLine("You entered invalid input. Please enter a valid number! ");
            }

            switch(calcType)
            {
                case "+":
                    Console.WriteLine("The result is:" + AddNumbers(firstNumber, secondNumber));
                    break;
                case "-":
                    Console.WriteLine("The result is:" + SubtractNumbers(firstNumber, secondNumber));
                    break;
                case "*":
                    Console.WriteLine("The result is:" + MultiplyNumbers(firstNumber, secondNumber));
                    break;
                case "/":
                    Console.WriteLine("The result is:" + DivideNumbers(firstNumber, secondNumber));
                    break;
                default:
                    Console.Error.WriteLine("Invalid sign input. " + calcType.ToString());
                    break;
            }

            RestartApp(args);

        }

        public static void RestartApp(string[] args)
        {
            Console.WriteLine("Do you want to start over? ( yes / no ) ");
            string answer = Console.ReadLine();
            if(answer == "yes")
            {
                Main(args);
            }
            else if(answer == "no")
            {
                Console.WriteLine("Thank you for using the application, see you soon!");
                return;
            }
            else
            {
                Console.WriteLine("Please type yes or no.");
                RestartApp(args);
            }
        }

        public static double AddNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double SubtractNumbers(double num1, double num2)
        {
            return num1 - num2;
        }

        public static double MultiplyNumbers(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double DivideNumbers(double num1, double num2)
        {
            return num1 / num2;
        }
    }
}