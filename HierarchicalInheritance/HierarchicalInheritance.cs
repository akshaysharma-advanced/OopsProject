using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsProject.HierarchicalInheritance
{
    public class Father
    {
        public string FatherName()
        {
            return "Mohit";
        }
    }

    public class Son : Father
    {
        public string SonName()
        {
            return "Ali";
        }
    }

    public class Daughter : Father
    {
        public string DaughterName()
        {
            return "Aayesha";
        }
    }
}
