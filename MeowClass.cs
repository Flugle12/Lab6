using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class MeowClass
    {
        private int countMeow;
        public static void GetAMeow(IMeow[] meows, int n=1)
        {
            foreach (var meow in meows)
            {
                meow.Meow(n);
            }
        }
    }
}
