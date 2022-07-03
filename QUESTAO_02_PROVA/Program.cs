using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUESTAO_02_PROVA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nome:julio Duarte Batista RA:6322046 

            /*2 – Fazer um programa para que mostre uma lista de cidades para o usuário e que ele informe o código da cidade escolhida.
               Em seguida pedir uma data para o usuário. Ao final deve ser apresentada em tela a data completa em formato extenso longo,
               juntamente com a cidade escolhida. 

             Exemplo: Bragança Paulista, 29 de junho de 2022.

             A relação das cidades é a seguinte:

             1 – Atibaia
             2 – Bragança Paulista
             3 – Mairiporã
             4 – Nazaré
             5 – Terra Preta
             6 – Extrema
             7 – Vargem

             Requisitos: Criar uma função para converter a data em extenso.*/
            int codigo,dia,mes,ano;

            Console.WriteLine("A relação das cidades é a seguinte: \n\n1 – Atibaia\n2 – Bragança Paulista\n3 – Mairiporã\n4 – Nazaré\n5 – Terra Pretan\n6 – Extrema\n7 – Vargem\n\n");
            Console.WriteLine("Digite o código referente a sua cidade: ");

            codigo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite uma data em formato: dd/mm/aaaa. ");
            Console.Write("\nDia: ");
            dia = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nMês: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nAno: ");
            ano = Convert.ToInt32(Console.ReadLine());

            if (codigo == 1)
            {
                Console.Write("\nAtibaia, ");
            }
            else if (codigo == 2)
            {
                Console.Write("\nBragança Paulista, ");
            }
            else if (codigo == 3)
            {
                Console.Write("\nMariporã, ");
            }
            else if (codigo == 4)
            {
                Console.Write("\nNazaré, ");
            }
            else if (codigo == 5)
            {
                Console.Write("\nTerra Preta, ");
            }
            else if (codigo == 6)
            {
                Console.Write("\nExtrema, ");
            }
            else if (codigo == 7)
            {
                Console.Write("\nNazaré, ");
            }
            else
            {
                Console.Write("\nCódigo invalido, tente novamente! ");
            }

            var date1 = new DateTime(ano, mes, dia);
            Console.WriteLine(date1.ToString("D", new System.Globalization.CultureInfo("pt-br")));

            Console.ReadLine();
        }
    }
}
