using System;

namespace zoo.Classes
{

    public class Axolotl : Amphibian
    {
        public override string Name { get; set; }
        public override string Food { get; set; }

        public Axolotl(string name, string food)
        {
            Name = name;
            Food = food;
        }
        public override bool Slimey { get; set; } = true;
        public override void Habitat()
        {
            Console.WriteLine("\tI'm not going to lie to you. What the hell is the difference between an amphibian and a reptile? It's late.");
        }
        public override void About()
        {
            Console.WriteLine($"This {Name} looks like a Pokemon.");
        }
        
    }


}