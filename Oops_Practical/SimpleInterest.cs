using System;
using System.Collections.Generic;
using System.Text;

namespace Oops_Practical
{
    public class SimpleInterest
    {
        public int amount, time, numberOfPeriods;
        public double rate, simpleInterst, compundInterst;

        public void Inputs()
        {
            Console.WriteLine("Please Enter the Amount: ");
            amount = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Time period: ");
            time = int.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the Rate of Interest: ");
            rate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please Enter the Number of Period: ");
            numberOfPeriods = int.Parse(Console.ReadLine());
        }
        public void Calculation()
        {
            simpleInterst = (amount * time * rate) / 100;
            Console.WriteLine("Calculated Simple Interest is " + simpleInterst);

            compundInterst = (amount * (1 + (rate / time)) * numberOfPeriods);
            Console.WriteLine("Calculated Compund Interest is " + compundInterst);
        }
    }
}
