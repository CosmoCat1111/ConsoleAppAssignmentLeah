using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignmentLeah
{
    class Program
    {
        static void Main(string[] args)
        { //with user input, doing a multiplication and display
            Console.WriteLine("Choose a number: ");
            string Num1Input = Console.ReadLine();
            int Num2Input = Convert.ToInt32(Num1Input);
            int total = Num2Input * 50;
            Console.WriteLine("Your number times 50 is: " + total);
            Console.ReadLine();


            //with user input, doing addition and display
            Console.WriteLine("Choose a number: ");
            string Add1Num = Console.ReadLine();
            int addNumbers = Convert.ToInt32(Add1Num);
            int total = addNumbers + 25;
            Console.WriteLine("Your number plus 25 is: " + total);
            Console.ReadLine();

            //with user input, doing division and display
            Console.WriteLine("Choose a number: ");
            string divNum = Console.ReadLine();
            int divNumbers = Convert.ToInt32(divNum);
            double total = divNumbers / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + total);
            Console.ReadLine();

            //with user input, doing division and display
            Console.WriteLine("Choose a number: ");
            string divNum = Console.ReadLine();
            int divNumbers = Convert.ToInt32(divNum);
            double total = divNumbers / 12.5;

            //with user input, converting input into int from bool and display
            Console.WriteLine("Choose a number: ");
            string yourNum = Console.ReadLine();
            bool trueOrFalse = Convert.ToInt32(yourNum) >= 50;
            Console.WriteLine(trueOrFalse);
            Console.ReadLine();

            //with user input, doing division and display remainder
            Console.WriteLine("Choose a number: ");
            string yourRemainder = Console.ReadLine();
            int remainder = Convert.ToInt32(yourRemainder) % 7;
            Console.WriteLine(remainder);
            Console.ReadLine();






        }
    }
}






