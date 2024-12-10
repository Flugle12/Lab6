using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    public class Cat : IMeow
    {
        private string name;    

        public Cat(string name)
        {
            this.name = name;
           
        }

        public override string ToString()
        {
            return $"кот: {name}";
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
