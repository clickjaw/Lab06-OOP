using System;

namespace zoo.Classes
{

    public class Bear : Mammal
    {
        public override string Name { get; set; }
        public override string Food { get; set; }

        public Bear(string name, string food){
            Name = name;
            Food = food;
        }

        public override void About(){
            Console.WriteLine($"\tWe have a {Name}.");
        }
        
        public override void fur(){
            Console.WriteLine("\t\t\tfurry af");
        }
        public override void descript()
        {
            Console.WriteLine($"\t\t{Name} likes {Food}.");
        }
    }

}