using System;

namespace PINInfiniteloop
{
    class Program
    {
        static void Main(string[] args)
        {

            //orig küsib kasutajl sisestada PIN koodi;
            // prog võrdleb sisestatud pinni arvuga 1234;
            //kui sisestatud pin on 1234, siis konsool kuvad "Tere Tulemas!"
            //kui sisestatakse vale pin siis konsool kuvad "Vale PIN. Proovige uuesti!"

            // katsetearv on piiramatud;

            bool loopActive = true; // boollean on olemas 2 väärtust true ja false
            int i = 0;
            while(loopActive)
            {
                Console.WriteLine("Palun sisesta PIN:");
                int userPin = Convert.ToInt32(Console.ReadLine());
                if (userPin == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    loopActive = false;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale PIN. Proovi uuesti.");
                    Console.WriteLine($"Oled vale PIN koodi {i} korda sisestanud.");
                }
            }
            Console.WriteLine("Kena Päeva!");
        }
    }
}
