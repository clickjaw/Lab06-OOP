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
            Betta betta = new Betta("Betta fish", "fish flakes");
            betta.About();
            betta.Habitat();


            Axolotl axolotl = new Axolotl("Axolotl", "worms");
            axolotl.About();
            axolotl.Habitat();

            Cardinal cardinal = new Cardinal("Cardinal", "bird seed");
            cardinal.Habitat();
            cardinal.About();

            Bear bear = new Bear("Bear", "small animals");
            bear.Habitat();
            bear.About();
            bear.descript();

            bear.fur();
            Crocodile crocodile = new Crocodile("Crocodile", "florida grandmas");
            crocodile.Habitat();
        }//end of Main
    }// end of Program
}// end of namespace