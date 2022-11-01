using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    class SimpleInterest
    {
        //public member variables
        public int principalAmount;
        public double rateOfInterest;
        public int years;

        public double CalculateInterest()
        {
            return principalAmount * rateOfInterest * years;
        }
    }
    internal class AccessModifiers
    {
        static void Main(string[] args)
        {
            SimpleInterest simpleInterest = new SimpleInterest();
            simpleInterest.principalAmount = 2000;
            simpleInterest.rateOfInterest = 0.1;
            simpleInterest.years = 3;
            Console.WriteLine("Simple Interest:" + simpleInterest.CalculateInterest());
        }
    }
}
