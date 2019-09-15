using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Informe um número inteiro: ");
            num = int.Parse(Console.ReadLine());

            {
                if (num < 0)
                    Console.WriteLine("Número é negativo");
                else if (num > 0 )
                    Console.WriteLine("Número é positivo");
                else
                    Console.WriteLine("Número é nulo");
            }
            Console.ReadKey();
        }
    }
}
