using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
            // progra, geneb juhusliku nr 1 kuni 10; viimane väärtus on 1 võrra suurem e siin 11, 100 puhul oleks siis 101
            // kui genereeeritud nr on 5 , prog lõpetab töö ja soovib "kena päeva!"
            // kui genereerib number on midagi muud, prog järkab tööd ;


        {
            Random rnd = new Random();
            int i = 0;
            while(i!=5)
            {
                int myRandomNumber = rnd.Next(1, 11);
                Console.WriteLine($"Juhuslik nr on : {myRandomNumber}");
                if(myRandomNumber==5)
                {
                    i = myRandomNumber;
                }
            }

            Console.WriteLine("Kena Päeva!");

           
        }
    }
}
