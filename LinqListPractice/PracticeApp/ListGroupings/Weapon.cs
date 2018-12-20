using System;
using System.Collections.Generic;
using System.Text;

namespace ListGroupings
{
    class Weapon
    {
        public string Name { get; set; }
        public int Damage { get; set; }

        public Weapon(string name, int dam)
        {
            Name = name;
            Damage = dam;
        }
    }
}
