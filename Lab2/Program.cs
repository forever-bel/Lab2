using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Parrot parrot = new Parrot("Kesha");
            Turtle turtle = new Turtle("Natasha");

            Person jack = new Person(parrot, "Jack");
            Person john = new Person(turtle, "John");

            jack.getPetInfo();
            john.getPetInfo();
        }
    }
}
