using System;

namespace zoo.Classes
{
    public abstract class Amphibian
    {
        public abstract string Name { get; set; }
        public abstract string Food { get; set; }

        
        public abstract void About();
        public abstract void Habitat();
        public abstract void Location();



        public abstract bool Slimey { get; set; }
    }
}