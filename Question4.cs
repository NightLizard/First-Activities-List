using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_4
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
                    Console.WriteLine("O número é negativo:{0} ", Math.Pow(num,2) );
                else
                    Console.WriteLine("O número é positivo ou igual a zero:{0} ", Math.Sqrt(num));
            }
            Console.ReadKey();
        }
    }
}
