using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace appV1.application.prime_number
{
    internal class PrimeNumber
    {
        public void Process(int number)
        {
            List<int> PrimeNumberList = new List<int>();
            List<int> NonPrimeNumberList = new List<int>();
            for (int i = 0; i < number; i++)
            {
                if (i > 0)
                {
                    int tempNum = i;
                    int cal = tempNum % 2;
                    if (Convert.ToBoolean(cal))
                    {
                        PrimeNumberList.Add(tempNum);
                    }
                    else
                    {
                        NonPrimeNumberList.Add((int)tempNum);
                    }
                }
            }
            this.PrintResult(PrimeNumberList, NonPrimeNumberList);


        }
        private void PrintResult(List<int> primeNumberList, List<int> nonPrimeNumberList)
        {
            Console.WriteLine(" number {0}", String.Join(",", nonPrimeNumberList));
            Console.WriteLine("prime number {0}", String.Join(",", primeNumberList));

        }
        public bool IsNumber(string text)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(text);
        }
    }
}
