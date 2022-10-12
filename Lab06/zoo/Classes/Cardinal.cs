using System;

namespace zoo.Classes
{

    public class Cardinal : Bird
    {
        public override string Name { get; set; }
        public override string Food { get; set; }

        public Cardinal(string name, string food)
        {
            Name = name;
            Food = food;
        }
        public override void Habitat()
        {
            {
                Console.WriteLine("Birds live on land. But they differ from Mammals in having feathers covering their body and being able to fly.");
            }
        }       
        public override void About()
        {
            Console.WriteLine("\tThey're birds.....so they fly.");
        }
    }

}