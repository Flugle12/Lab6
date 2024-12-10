using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class BIGCat : IMeow
    {
        private string name;

        public BIGCat(string name)
        {
            this.name = name;
        }

        public void Meow()
        {
            Console.WriteLine($"{name}: MEOOOW");
        }

        public void Meow(int n)
        {
            Console.Write($"{name}: MEOOOW");
            for (int i = 1; i < n; i++)
            {
                Console.Write("-MEOOOW");
            }
            Console.WriteLine('!');
        }
    }
}
