using System;
using System.Collections.Generic;
using System.Linq;

namespace ListGroupings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Weapon> tigWeapons = new List<Weapon>()
            {
                new Weapon("Claws", 5),
                new Weapon("Tail", 3),
                new Weapon("Teeth", 10)

            };

            List<Weapon> monWeapons = new List<Weapon>()
            {
                new Weapon("Fists", 5),
                new Weapon("Tail", 7),
                new Weapon("Kick", 4)

            };

            List<Weapon> birWeapons = new List<Weapon>()
            {
                new Weapon("Wings", 5),
                new Weapon("Claws", 7),
                new Weapon("Peck", 11)

            };

            List<Animal> animals = new List<Animal>()
            {
                new Animal("Tiger",tigWeapons ),
                new Animal("Monkey", monWeapons),
                new Animal("Bird", birWeapons),
                new Animal("Hawk", birWeapons),
                 new Animal("Panther",tigWeapons )

            };

            var result = from animal in animals
                         orderby animal.Name
                         group animal by animal.Weapons[0].Name;

            foreach (var group in result)
            {
                Console.WriteLine(group.Key);

                foreach(var animal in group)
                {
                    Console.WriteLine("\t{0} {1} {2}", animal.Name, animal.Weapons[1].Name, animal.Weapons[2].Name);
                }
            }

            Console.ReadLine();

        }
    }
}
