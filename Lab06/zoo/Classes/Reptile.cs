using System;

namespace zoo.Classes
{
    public abstract class Reptile
    {
        public abstract string Name { get; set; }
        public abstract string Food { get; set; }
        public virtual void Habitat()
        {
            Console.WriteLine("Reptiles have the ability, depending on species, to live on land and in water.");
        }
        public abstract void About();
        public abstract void Location();
    }
}