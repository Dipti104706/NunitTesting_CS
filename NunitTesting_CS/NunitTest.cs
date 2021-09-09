using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTesting_CS
{
    class NunitTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose a option you want: \n 1-Notes retuned by Vending Machine \n 2-Day of the week \n 3-Temperature Conversion \n 4-Calculation of Monthlyy payment \n 5-Squareroot of a number \n 6-Decimal to binary conversion \n 7-Swap nibble");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    VendingMachine.UserInputNotes();
                    Console.ReadLine();
                    break;
                case 2:
                    dayWeek.UserInput();
                    Console.ReadLine();
                    break;
                case 3:
                    TemperatureConversion.UserInput();
                    Console.ReadLine();
                    break;
                case 4:
                    MonthyPayment.UserInput();
                    Console.ReadLine();
                    break;
                case 5:
                    SquareRoot.sqrtRoot();
                    Console.ReadLine();
                    break;
                case 6:
                    toBinary.ConversiontoBinary();
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Please put a valid input");
                    break;
            }
        }
    }
}
