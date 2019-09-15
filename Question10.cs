using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question10
{
    class Program
    {
        static void Main(string[] args)
        {
            double Lcombustivel, Lvalor, Vcombustivel, Vdesconto = 0;

            Console.WriteLine("Qual a quantidade de combustível abastecida?: L ");
            Lcombustivel = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o valor do combustível ?: R$ ");
            Lvalor = double.Parse(Console.ReadLine());

            Vcombustivel = Lcombustivel * Lvalor;

            {
                if ((Lcombustivel >= 10) && (Lcombustivel <= 30)) // 1% desconto per L
                { 
                    Vdesconto = 1 * (Vcombustivel / 100);
                Console.WriteLine("O valor do desconto é: R${0}", Vdesconto);
                }
                  else if ((Lcombustivel > 30) && (Lcombustivel < 40)) // 2% desconto per L
                {
                    Vdesconto = 2 * (Vcombustivel / 100);
                    Console.WriteLine("O valor do desconto é : R${0}", Vdesconto);
                }
                else  // 3% desconto per L
                {
                    Vdesconto = 2.5 * (Vcombustivel / 100);
                    Console.WriteLine("O valor do desconto é: R${0}", Vdesconto);
                }
                


            }
              Console.WriteLine("O valor final em Litros a pagar é: R${0}", Vcombustivel-Vdesconto);
                Console.ReadKey();
        }
    }
}
