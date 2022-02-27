using System;

namespace GuessingGameInfinite_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int cpuNum = rnd.Next(1, 11);

            bool loopActive = true;
            while (loopActive)
            {
                Console.WriteLine("Palun arvake ära nr 1 -10.");
                int userNum = Convert.ToInt32(Console.ReadLine());
                
                if (userNum == cpuNum)
                
                {
                    Console.WriteLine($"Õige number on {cpuNum}. Palju õnne arvasite numbri ära ");
                    loopActive = false;

                }
                else
                {
                    Console.WriteLine("Vale nr. proovige uuesti");
                }
            }
        }
    }
}
