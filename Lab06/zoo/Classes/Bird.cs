using System;

namespace zoo.Classes
{
    public abstract class Bird
    {
        public abstract string Name { get; set; }
        public abstract string Food { get; set; }
        public abstract void Habitat();
        public abstract void About();
        public abstract void Location();
    }
}