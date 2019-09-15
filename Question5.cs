using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;

            Console.WriteLine("Informe um número: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe um número: ");
            num2 = int.Parse(Console.ReadLine());

            {
                if (num1 < num2)
                    Console.WriteLine("{0} é menor que {1}.", num1, num2); //o primeiro número é menor que o segundo.
                if (num1 > num2)
                    Console.WriteLine("{0} é maior que {1}.", num1 , num2); // o primeiro número é maior.
                else
                Console.WriteLine("{0} e {1} São iguais.", x,y);

            }

            Console.ReadKey();
        }
    }
}
