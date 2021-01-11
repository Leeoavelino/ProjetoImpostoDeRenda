using System;
using System.Collections.Generic;
using ProjetoContribuintes.Entities;

namespace ProjetoContribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contribuintes> list = new List<Contribuintes>();


            Console.Write("Digite o numero de contribuintes analisados: ");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Dados do contribuinte #{i}: ");

                Console.Write("Pessoa fisica ou Juridica (f/j): ");
                char ch = char.Parse(Console.ReadLine());

                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();

                Console.Write("Rendimento anual: ");
                double rendimentoAnual = double.Parse(Console.ReadLine());
                
                if(ch == 'f')
                {
                    Console.Write("Quanto foram os seus gastos com saude: ");
                    double gastosSaude = double.Parse(Console.ReadLine());

                    list.Add(new PessoaFisica(nome, rendimentoAnual, gastosSaude));

                }

                else
                {
                    Console.Write("Quantos colaboradores na empresa: ");
                    int funcionarios = int.Parse(Console.ReadLine());

                    list.Add(new PessoaJuridica(nome, rendimentoAnual, funcionarios));

                }

            }

            double soma = 0;

            Console.WriteLine();

            Console.WriteLine("IMPOSTOS A PAGAR: ");

            foreach(Contribuintes con in list)
            {
                double impostoPago = con.impostoPago();
               
                Console.WriteLine(con.Nome + " : R$ " + impostoPago.ToString("F2" ));

                soma += impostoPago;
            
            
            }

            Console.WriteLine();

            Console.WriteLine("Total de impostos pagos: R$ " + soma.ToString("F2"));


        }
    }
}
