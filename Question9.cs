using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question9
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, delta, a, b, c;

            Console.WriteLine("Insira um número: ");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira um número: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira um número: ");
            c = double.Parse(Console.ReadLine());


            delta = (Math.Pow(b, 2)) - (4 * a * c);
            Console.WriteLine("Delta é{0}:", delta);
            {
                if (delta > 0)
                    Console.WriteLine("Existe 2 raízes: x1 e x2!");
                else if (delta == 0)
                    Console.WriteLine("Existe somente 1 raíz: x1=x2!");
                else
                Console.WriteLine("Não existem raízes reais!");
            }
            x1 = ((-b) + Math.Sqrt(delta)) / (2 * a);
            x2 = ((-b) - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("A primeira raiz de X é:{0} ", x1);
            Console.WriteLine("A segunda raiz de X é:{0} ", x2);

            Console.ReadKey();
        }
    }
}
