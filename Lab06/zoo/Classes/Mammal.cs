using System;

namespace zoo.Classes{
    public abstract class Mammal{
        public abstract string Name{ get; set;}
        public abstract string Food { get; set;}
        public virtual void Habitat()
        {
            Console.WriteLine("Mammals live on land.");
        }
        public abstract void fur();
        public abstract void descript();
        public abstract void About();
    }
}