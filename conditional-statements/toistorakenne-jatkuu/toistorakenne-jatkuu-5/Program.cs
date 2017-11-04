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
<<<<<<< HEAD


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
=======
            

            double numx;
            numx = rnd.NextDouble();

            if (numx <= 0.4)
            {
                Console.WriteLine(" 1 ");
            }
            else if (numx < 0.6)
            {
                Console.WriteLine(" X ");
            }
            else Console.WriteLine(" 2 ");

            for (= 13;  ++)
               
            
            Console.ReadKey();

        }  
                               
        
>>>>>>> 9b2d0f650032bea87f088a3b888334103c356e00
    }
}
