using System;

using zoo.Classes;

namespace zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Digital Native Zoo.");
            Console.WriteLine("I'm the warden of this unethical playground. Continue?");
            Console.ReadKey();
            Console.WriteLine("\n");
            Betta betta = new Betta("Betta fish", "fish flakes", "toddler bedrooms", "water");
            betta.About();
            betta.Habitat();
            betta.Location();


            Axolotl axolotl = new Axolotl("Axolotl", "worms", "Lake Xochimilco", "high-altitude body of water");
            axolotl.About();
            axolotl.Habitat();
            axolotl.Location();

            Cardinal cardinal = new Cardinal("Cardinal", "bird seed", "Central and Eastern North America", "edge of woodlands");
            cardinal.Habitat();
            cardinal.About();
            cardinal.Location();

            Bear bear = new Bear("Brown Bear", "salmon", "North America", "Everywhere");
            bear.Habitat();
            bear.About();
            bear.Location();
            bear.fur();
            Crocodile crocodile = new Crocodile("Crocodile", "florida grandmas", "South Florida", "swamp ass climate");
            crocodile.Habitat();
            crocodile.About();
            crocodile.Location();

        }//end of Main
    }// end of Program
}// end of namespace