using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject
{
    public class Country
    {
        public void CountryName()
        {
            Console.WriteLine("India");
        }
    }

    public class State : Country
    {
        public void StateName()
        {
            Console.WriteLine("Gujarat");
        }
    }

    public class City : State
    {
        public void CityName()
        {
            Console.WriteLine("Ahmedabad");
        }
    }
}
