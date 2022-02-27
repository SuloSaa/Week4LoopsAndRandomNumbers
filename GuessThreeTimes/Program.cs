using System;

namespace GuessThreeTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            //prog genereerib juhuslikku nr 1 kuni 10;
            //kasutaja peab selle nr ära arvama;
            // kui kasutaja arvas nr ära , siis ta on on mängu võitnud;
            // kasutajal on 3 katset, kui ei ole 3 ktasega ära arvata sis võidab arvuti ;
            // prog genereerib juhusliku nr ühe korra;
            Random rnd = new Random();
            int cpuNum = rnd.Next(1, 11);
            int i = 0;

            while (i < 3)
            {
                Console.WriteLine("Palun arvake ära nr 1 -10.");
                int userNum = Convert.ToInt32(Console.ReadLine());

                if (userNum == cpuNum)

                {
                    Console.WriteLine($"Õige number on {cpuNum}. Palju õnne arvasite numbri ära ");
                    break;

                }
                else
                {
                    i++;
                    Console.WriteLine($"Vale nr. {3 - i}proovige uuesti");
                }
            }
        }
    }
}
