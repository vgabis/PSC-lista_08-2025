using System;

//5. Faça um programa com uma função chamada somaImposto.A função possui
//dois parâmetros formais: taxaImposto, que é a quantia de imposto sobre
//vendas expressa em porcentagem e custo, que é o custo de um item antes do
//imposto.A função “altera” o valor de custo para incluir o imposto sobre
//vendas.

namespace ListaExercicio
{
      class Atividade_05
      {
            static void Main5()
            {
                  Console.Write("Digite o custo do item (sem imposto): ");
                  double custo = double.Parse(Console.ReadLine());

                  Console.Write("Digite a taxa de imposto (%): ");
                  double taxaImposto = double.Parse(Console.ReadLine());

                  double custoComImposto = SomaImposto(taxaImposto, custo);

                  Console.WriteLine("O custo com imposto é: R$ " + custoComImposto.ToString("F2"));

                  Console.WriteLine("Pressione qualquer tecla para sair...");
                  Console.ReadKey();
            }

            // Função que calcula o custo com imposto
            static double SomaImposto(double taxaImposto, double custo)
            {
                  return custo + (custo * taxaImposto / 100);
            }

      }
}
