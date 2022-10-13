using System;

namespace zoo.Classes
{

    public class Axolotl : Amphibian
    {
        public override string Name { get; set; }
        public override string Food { get; set; }
        public string AnimalLocation{get; set;}
        public string LocationClimate{get; set;}

        public Axolotl(string name, string food, string location, string climate)
        {
            Name = name;
            Food = food;
            AnimalLocation = location;
            LocationClimate = climate;
        }
        public override bool Slimey { get; set; } = true;
        public override void Habitat()
        {
            Console.WriteLine("\tI'm not going to lie to you. What the hell is the difference between an amphibian and a reptile? It's late.");
        }
        public override void About()
        {
            Console.WriteLine($"This {Name} looks like a Pokemon and eats {Food}.");
        }
        public override void Location(){
            Console.WriteLine($"\t\t{Name} are exclusively located in {AnimalLocation} which has a {LocationClimate}.");
        }
        
    }


}