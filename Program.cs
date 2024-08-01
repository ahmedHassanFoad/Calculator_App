using System.Collections.Specialized;

namespace CalculatorApp
{
    internal class Program
    {

        public static decimal AddTwoNumbers(decimal a, decimal b)
        {
            return a + b; 
        }



        public static decimal SubcractTwoNumbers(decimal a, decimal b)
        { 
         return (decimal)a - (decimal)b;
        }


        public static decimal MultiplyTwoNumbers(decimal a, decimal b)
        {
            return a * b; 
        }


        public static decimal DevideTwoNumbers(decimal a, decimal b)
        {
            return a / b;

        }



        public static decimal ReadDecimalFromConsole()
        {
            
            string input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal result))
            {
                return result;
            }
            else
            {
                throw new ArgumentException("Invalid input. Please enter a valid decimal value.");
            }
        }


        static void Main(string[] args)
        {
            string operand;
            string decision;
            decimal result;
            decimal Num_1;
            decimal Num_2;
            bool flag = true;
            while (flag)
            {

                Console.WriteLine("Enter the first number:");
                Num_1 = ReadDecimalFromConsole();
                Console.WriteLine("Enter the second number:");
                Num_2 = ReadDecimalFromConsole();

                Console.WriteLine("choose operation from ( + , - , * , / )");
                operand = Console.ReadLine();
                switch (operand)
                {
                    case "+":
                        result = AddTwoNumbers(Num_1, Num_2);
                        Console.WriteLine($"{Num_1}{operand}{Num_2}= {result}");
                        break;
                    case "-":
                        result = SubcractTwoNumbers(Num_1, Num_2);
                        Console.WriteLine($"{Num_1}{operand}{Num_2}= {result}");
                        break;
                    case "*":
                        result = MultiplyTwoNumbers(Num_1, Num_2);
                        Console.WriteLine($"{Num_1}{operand}{Num_2}= {result}");
                        break;
                    case "/":
                        if (Num_2 == 0)
                        {
                            Console.WriteLine("cannot devide by Zero.");

                            break;
                        }
                        else
                        {
                            result = DevideTwoNumbers(Num_1, Num_2);
                            Console.WriteLine($"{Num_1}{operand}{Num_2}= {result}");
                            break;
                        }


                }
                Console.WriteLine("To make another operation press :(y)");
                Console.WriteLine("if you want to exit type : (exit)");
                decision=Console.ReadLine();
                if (decision.ToLower() == "y")
                {
                    flag = true;
                }
                else if (decision.ToLower() == "exit")
                {
                    flag = false;
                }
                else
                {
                    Console.WriteLine("invaid input");
                   
                }
            }
                
        }
    }
}
