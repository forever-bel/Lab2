using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Turtle : Animal
    {
        public Turtle(string name) : base(name) { }

        public override void makeNoise()
        {
            Console.WriteLine("  _____     ____\n" +
                               " /      \\  |  o | \n" +
                               "|        |/ ___\\| \n" +
                               "|_________/     \n" +
                               "|_|_| |_|_|");
        }
    }
}
