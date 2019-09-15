using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question7
{
    class Program
    {
        static void Main(string[] args)
        {
            string Candidato1, Candidato2;
            int votos1, votos2,idade1,idade2;

            Console.WriteLine("Informe o nome do primeiro candidato: ");
            Candidato1 = Console.ReadLine();
            Console.WriteLine("Informe os votos do primeiro candidato. ");
            votos1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe a idade do primeiro candidato. ");
            idade1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do segundo candidato: ");
            Candidato2 = Console.ReadLine();
            Console.WriteLine("Informe os votos do segundo candidato. ");
            votos2 = int.Parse(Console.ReadLine());            
            Console.WriteLine("Informe a idade do segundo candidato. ");
            idade2 = int.Parse(Console.ReadLine());

            Console.Clear();

            {
                if (votos1 > votos2) //candidato 1 venceu
                    Console.WriteLine("Candidato {0} venceu! Sua vantagem de votos foi: {1}", Candidato1, votos1 - votos2);
                else if (votos2 > votos1) //candidato 2 venceu
                    Console.WriteLine("Candidato 2 venceu! Sua vantagem de votos foi: {1}", Candidato2, votos2 - votos1);
                else if  (idade1 > idade2)//Houve empate nos votos. 
                    Console.WriteLine(" E o candidato {0} ganha por ser o mais velho. Sua idade é {1} anos", Candidato1, idade1);
                else if  (idade1 < idade2) 
                    Console.WriteLine(" E o candidato {0} ganha por ser o mais velho. Sua idade é {2} anos", Candidato2, idade2);
                else //Ocorreu empate geral.
                    Console.WriteLine("Novas eleições São necessárias!");
            }


            Console.ReadKey();
        }
    }
}
