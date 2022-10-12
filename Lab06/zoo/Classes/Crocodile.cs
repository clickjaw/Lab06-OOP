using System;

namespace zoo.Classes
{

    public class Crocodile : Reptile
    {
        public override string Name { get; set; }
        public override string Food { get; set; }

        public Crocodile(string name, string food)
        {
            Name = name;
            Food = food;
        }

        public override void About()
        {
            Console.WriteLine($"{Name}s eat people in Florida.");
        }
    }

}