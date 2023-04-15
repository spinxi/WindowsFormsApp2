using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    internal class Class_2
    {
        public Class_1 Metodi_1(int[,] array)
        {
            int sum = 0;
            foreach (int item in array) 
            { 
                if (item >= 15 && item <= 25)
                {
                    sum += item;
                }
            }
            Class_1 obj_jami = new Class_1(sum);
            return obj_jami;
        }
    }
}
