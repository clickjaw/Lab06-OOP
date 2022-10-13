using System;

namespace zoo.Classes
{

    public class Betta : Fish
    {
        public override string Name { get; set; }
        public override string Food { get; set; }
        public string AnimalLocation{get; set;}
        public string LocationClimate{get; set;}

        public Betta(string name, string food, string location, string climate)
        {
            Name = name;
            Food = food;
            AnimalLocation = location;
            LocationClimate = climate;
        }

        public override void Strong()
        {
            Console.WriteLine("They can withstand a lot. A 4 year old can't kill them.");
        }
        public override void About()
        {
            Console.WriteLine($"We have one {Name}. We never said we were a good zoo.");
        }
        public override void Location()
        {
            Console.WriteLine($"\t\t{Name} fish are found in {AnimalLocation}. They live in {LocationClimate}.");
        }

    }

}