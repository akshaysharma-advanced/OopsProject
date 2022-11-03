using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject.AccessModifiers
{
    public class SimpleInterest
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
}
