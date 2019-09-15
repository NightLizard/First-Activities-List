using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Informe um número: ");
            num = int.Parse(Console.ReadLine());

            num = num ^ 2;
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
