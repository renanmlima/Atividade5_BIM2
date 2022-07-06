using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_BIM2
{
    internal class Program
    {
            /* |====================================================| */
            /* |* AUTOR: RENAN LIMA | RA: 6321300 ******************| */
            /* |* DATA DE CRIAÇÃO: 06.JUL.2022 *********************| */
            /* |* PROVA FECHAMENTO DE NOTA DO 2 BIMESTRE ***********| */
            /* |* MATÉRIA: LÓGICA DE PROGRAMAÇÃO *******************| */
            /* |* SEMESTRE: 1 | INSTITUIÇÃO: UNIFAAT ATIBAIA *******| */
            /* |* CURSO: ANÁLISE E DESENVOLVIMENTO DE SISTEMAS *****| */
            /* |====================================================| */

        
        static void Main(string[] args)
        {

            string j = "S";
            do
            {

                Console.Clear();
                for (int i = 1; i <= 100; i++)
                {

                    if (i % 2 == 0)
                    {
                        Console.WriteLine(i);
                    }

                }
                Console.WriteLine();

                Console.Write("Usar novamente? (S/N): ");

                j = Console.ReadLine();

                if (j != "N" && j != "n" && j != "S" && j != "s")
                {

                    Console.WriteLine("ERRO!");
                    Console.ReadKey();
                    Environment.Exit(0);

                }


            }
            while (j == "S" || j == "s");

            Console.WriteLine("OBRIGADO POR USAR :)");
            Console.ReadKey();
        }
    }
}
