using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Parrot : Animal
    {
        public Parrot(string name) : base(name) { }

        public override void makeNoise()
        {
            Console.WriteLine("         /////\n" +
                               "     (  - v -  )\n" +
                               "  (   )      (    ) \n" +
                               "       v.   v");
        }
    }
}
