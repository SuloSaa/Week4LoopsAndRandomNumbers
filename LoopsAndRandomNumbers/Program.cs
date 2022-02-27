using System;

namespace LoopsAndRandomNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //orig küsib kasutajl sisestada PIN koodi;
            // prog võrdleb sisestatud pinni arvuga 1234;
            //kui sisestatud pin on 1234, siis konsool kuvad "Tere Tulemas!"
            //kui sisestatakse vale pin siis konsool kuvad "Vale PIN. Proovige uuesti!"
            // kasutajal on kolm katset; i < 3 (i on väiem kui 3) 


            int i = 0; // i - interation
            while(i<3) // while-loop(esimene katse on 0 mitte 1  i=1; es 1<3 siis tulemuseks on True ; 1+1=2 < 3  true; 
            {
                Console.WriteLine("Sisesta PIN:");
                int userPIN = Convert.ToInt32(Console.ReadLine());

                if(userPIN == 1234)
                {
                    Console.WriteLine("Tere tulemast!");
                    break;

                }
                else
                {
                    i = i + 1; // == i++
                    Console.WriteLine($"Vale PIN. {3 - i} katset on jäänud.");
                }

                
            
                
            }

            Console.WriteLine("Kena päeva!");

        }
    }
}
