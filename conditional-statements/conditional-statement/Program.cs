using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //define instructions
            Console.WriteLine("Ohjelma tulostaa parillinen tai pariton");
            bool isNumber;
            Console.Write("Syötä luku: ");
            string userInput;
            userInput = Console.ReadLine();

            //define variables

            int evaluatedNumber;
            isNumber = int.TryParse(userInput, out evaluatedNumber);

            //program logic

            if (evaluatedNumber % 2 == 0)
            {
                Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on parillinen");
            }
            else
            {
                Console.WriteLine($"Syötit luvun {evaluatedNumber}, se on pariton");
            }

            Console.ReadKey();




        }
    }
}
