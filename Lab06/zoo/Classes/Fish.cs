using System;

namespace zoo.Classes
{
    public abstract class Fish
    {
        public abstract string Name { get; set; }
        public abstract string Food { get; set; }
        public virtual void Habitat()
        {
            Console.WriteLine("\tFish live in water.");
        }
        public abstract void Strong();
        public abstract void About();
    }
}