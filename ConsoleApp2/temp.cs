using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class temp
    {
       public double t1 { set; get; }
        public double t2 { set; get; }
        public double t3 { set; get; }

        public bool isTempIce()
        {
            if (t1 == 0 || t2 == 0 || t3 == 0)
                return true;
            else
                return false;
        }

    }
}
