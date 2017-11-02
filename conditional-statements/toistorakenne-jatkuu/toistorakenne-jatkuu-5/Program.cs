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
                               
        
    }
}
