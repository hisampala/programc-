using appV1.application.calculated_use_water;
using appV1.application.prime_number;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appV1
{
    enum MenuProgram
    {
        Exit = 0,
        CalculateUserWarter = 1,
        PrimeNumber = 2,

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            bool programRun = true;
            Console.WriteLine("start program");
            do
            {
                Console.WriteLine("----------------------------------------------------------");
                Console.WriteLine("Please select the program menu.");
                Console.WriteLine("[0]:{0}\n[1]:{1}\n[2]:{2}", "Exit", "CalculateUserWarter", "PrimeNumber");
                Console.Write("Menu : ");
                int Program = Convert.ToInt16(Console.ReadLine());
                switch (Program)
                {
                    case (int)MenuProgram.CalculateUserWarter:
                        CalculateUseWater calculateUseWater = new CalculateUseWater();
                        Console.Write("Please enter the amount of water usage. :");
                        int useunit = Convert.ToInt16(Console.ReadLine());
                        calculateUseWater.Process(useunit);
                        break;
                    case (int)MenuProgram.PrimeNumber:
                        PrimeNumber primeNumber = new PrimeNumber();
                        Console.Write("Please enter the Number:");
                        string input = Console.ReadLine();
                        if (!primeNumber.IsNumber(input)) {
                            Console.WriteLine("[error]: please enter number ");
                            break;
                        };
                        int number = Convert.ToInt32(input);
                        primeNumber.Process(number);
                        break;
                    case (int)MenuProgram.Exit:
                        programRun = false;
                        Console.WriteLine("Please Pass Enter Exit a Program");
                        break;
                  
                        
                }
            }
            while (programRun);
            
            
            Console.ReadKey();
        }
    }
}
