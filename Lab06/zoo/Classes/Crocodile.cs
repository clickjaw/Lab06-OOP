using System;
using zoo.Interfaces;

namespace zoo.Classes
{

    public class Crocodile : Reptile, IHabitat
    {
        public override string Name { get; set; }
        public override string Food { get; set; }
        public string AnimalLocation{get; set;}
        public string LocationClimate{get; set;}

        public Crocodile(string name, string food, string location, string climate)
        {
            Name = name;
            Food = food;
            AnimalLocation = location;
            LocationClimate = climate;
        }

        public override void About()
        {
            Console.WriteLine($"\t{Name}s eat {Food}.");
        }

        public override void Location()
        {
            Console.WriteLine($"\t\t{Name}s live in {AnimalLocation} with a {LocationClimate} climate");
        }
    }


}