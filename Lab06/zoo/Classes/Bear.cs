using System;
using zoo.Interfaces;

namespace zoo.Classes
{

    public class Bear : Mammal, IHabitat
    {
        public override string Name { get; set; }
        public override string Food { get; set; }
        public string AnimalLocation{get; set;}
        public string LocationClimate{get; set;}

        public Bear(string name, string food, string location, string climate){
            Name = name;
            Food = food;
            AnimalLocation = location;
            LocationClimate = climate;
        }

        public override void About(){
            Console.WriteLine($"\tWe have a {Name}.");
        }
        
        public override void fur(){
            Console.WriteLine("\t\t\tfurry af");
        }
        public override void Location()
        {
            Console.WriteLine($"\t\t{Name}s likes {Food}. They are found in {AnimalLocation}");
        }
    }

}