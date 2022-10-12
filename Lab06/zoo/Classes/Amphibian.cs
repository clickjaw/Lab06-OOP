using System;

namespace zoo.Classes
{
    public abstract class Amphibian
    {
        public abstract string Name { get; set; }
        public abstract string Food { get; set; }
        public abstract void Habitat();
        
        public abstract bool Slimey{get; set;}
        public abstract void About();
    }
}