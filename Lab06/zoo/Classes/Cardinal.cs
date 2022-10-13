using System;
using zoo.Interfaces;

namespace zoo.Classes
{

    public class Cardinal : Bird, IHabitat
    {
        public override string Name { get; set; }
        public override string Food { get; set; }
        public string AnimalLocation{get; set;}
        public string LocationClimate{get; set;}

        public Cardinal(string name, string food, string location, string climate)
        {
            Name = name;
            Food = food;
            AnimalLocation = location;
            LocationClimate = climate;
        }
        public override void Habitat()
        {
            {
                Console.WriteLine("Birds live on land. But they differ from Mammals in having feathers covering their body and being able to fly.");
            }
        }       
        public override void About()
        {
            Console.WriteLine($"\t{Name}s are birds.....so they fly. They eat {Food}.");
        }

        public override void Location()
        {
            Console.WriteLine($"\t\t{Name}s are located in {AnimalLocation} and live around the {LocationClimate}.");
        }
    }

}