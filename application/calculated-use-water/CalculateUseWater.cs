using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appV1.application.calculated_use_water
{
    internal class CalculateUseWater
    {
        
        public void  Process(int unituse)
        {
            int fee = 50;
            int rate = 0;
            if (unituse >= 1 && unituse <= 10)
            {
                rate = 5;
            }
            else if (unituse >= 11 && unituse <= 20)
            {
                rate = 10;
            }
            else if (unituse >= 21 && unituse <= 30)
            {
                rate = 30;
            }
            else if (unituse >= 31)
            {
                rate = 50;
            }
            int sum = (unituse - 1) * rate;
            int total = sum + fee;
            this.PrintBill(total);
        }
        public void PrintBill(int total)
        {
            Console.WriteLine("your payment : {0} bath", total);
        }
    }
}
