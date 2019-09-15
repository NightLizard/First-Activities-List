using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question6
{
    class Program
    {
        static void Main(string[] args)
        {
            float compra, pagamento, troco;

            Console.Write("O valor da sua compra é:R$ ");
            compra = float.Parse(Console.ReadLine());
            Console.Write("Pagamento realizado foi:R$ ");
            pagamento = float.Parse(Console.ReadLine());

            Console.Clear();

            troco = pagamento - compra;
            {
                if (pagamento < compra)
                    Console.WriteLine("Transação não realizada. Tente novamente!");
                else
                    Console.WriteLine("O valor do seu troco é: R$ {0}", troco);
            }

            Console.ReadKey();
        }
    }
}
