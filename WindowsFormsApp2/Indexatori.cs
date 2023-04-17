using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Indexatori
    {
        public double[,] masivi = new double[2, 3] {{ 1, 2, 3 },{4, 5, 6}};

        public double this[int striqoni, int sveti]
        {
            get 
            { 
                return masivi[striqoni,sveti]; 
            }

         
        }

    }
}
