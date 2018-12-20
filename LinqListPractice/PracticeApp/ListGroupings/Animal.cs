using System;
using System.Collections.Generic;
using System.Text;

namespace ListGroupings
{
    class Animal
    {
        public string Name { get; set; }
        public List<Weapon> Weapons { get; set;}

        public Animal(string name, List<Weapon> weps)
        {
            Name = name;
            Weapons = weps;
        }
    }
}
