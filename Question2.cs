using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question02
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Informe um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            {
                if (num % 2 == 0)
                    Console.WriteLine("Número é par");
                else
                    Console.WriteLine("Número é ímpar");

            }
            Console.ReadKey();
        }
    }
}
