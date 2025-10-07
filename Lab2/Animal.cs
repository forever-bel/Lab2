using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public abstract class Animal : Pet
    {
        protected string _name;

        public Animal(string name)
        {
            _name = name;
        }


        public string getName()
        {
            return _name;
        }

        public abstract void makeNoise();
    }
}
