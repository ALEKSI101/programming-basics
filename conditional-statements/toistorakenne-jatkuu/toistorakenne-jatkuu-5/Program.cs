using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toistorakenne_jatkuu_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();


            Console.WriteLine("Ohjelma tulostaa vakioveikkauksen rivin. ");


            double luku;
            char merkki;




            for (int i = 1; i <= 13; i++)
            {

                luku = rnd.NextDouble();

                if (luku <= 0.4)
                {
                    merkki = '1';
                }
                else if (luku < 0.6)
                {
                    merkki = 'X';
                }
                else
                {
                    merkki = '2';
                }
                Console.WriteLine($"{i}. {merkki} ");

            }



            Console.ReadKey();
        }
    }
}
