using System;

namespace zoo.Classes
{
    public abstract class Species
    {
        public abstract string Name { get; set; }
        // public abstract string Genus { get; set; } // type of animal
        public abstract string Food { get; set; }
        // public abstract void Explain();

        public abstract void About();
        public abstract void Strong();

        

    }//end class
}//end namespace
