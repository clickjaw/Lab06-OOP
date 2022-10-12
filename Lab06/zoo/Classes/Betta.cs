using System;

namespace zoo.Classes
{

    public class Betta : Fish
    {
        public override string Name { get; set; }
        public override string Food { get; set; }

        public Betta(string name, string food)
        {
            Name = name;
            Food = food;
        }
        public override void strong(){
            Console.WriteLine("\tThey can withstand a lot. A 4 year old can't kill them.");
        }
        public override void About()
        {
            Console.WriteLine($"We have one {Name}. We never said we were a good zoo. ");
        }
    }

}