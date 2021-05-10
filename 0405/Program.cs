using System;

namespace _0405
{
    class Program
    {
        static void Main(string[] args)
        {
            
           for (int cinquenta = 0; cinquenta <= 50; cinquenta++)
           {
               Console.WriteLine("Contador: " + cinquenta);
           }

           for (int cem = 200; cem >= 100; cem--)
           {
               Console.WriteLine("Contador: " + cem);
           }

           for (double i = 0; i < 5; i = i + 0.1)
           {
               Console.WriteLine("Contador: " + i);
           }

            bool idadeCerta = false;

            while (idadeCerta == false)
            {
                Console.WriteLine("Qual a idade de tyler joseph?");
                int idadeTyler = int.Parse(Console.ReadLine());

                if (idadeTyler == 32)
                {
                    Console.WriteLine("Acertou miseravi!!");
                    idadeCerta = true;
                } else
                {
                    Console.WriteLine("Errou");
                }
            }

            idadeCerta = false;

            do
            {
                Console.WriteLine("Qual a idade de tyler joseph?");
                int idadeTyler = int.Parse(Console.ReadLine());

                if (idadeTyler == 32)
                {
                    Console.WriteLine("Acertou miseravi!!");
                    idadeCerta = true;
                } else
                {
                    Console.WriteLine("Errou");
                }

            } while (idadeCerta == false);

            Console.WriteLine("Fim sistema");
        }
    }
}
