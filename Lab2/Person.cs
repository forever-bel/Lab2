using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Person
    {
        private Pet _pet;
        private string _name;

        public Person(Pet pet, string name)
        {
            _pet = pet;
            _name = name;
        }

        public void setPet(Pet pet)
        {
            _pet = pet;
        }

        public void getPetInfo()
        {
            Console.WriteLine($"Pet for {_name} is named {_pet.getName()}");
            Console.WriteLine("And it sounds like this:");
            _pet.makeNoise();
        }
    }
}
