using System;

//2. Faça um programa para imprimir:
//1
//1 2
//1 2 3
//.....
//1 2 3 ... n
//para um n informado pelo usuário.
//Use uma função que receba um valor n inteiro imprima até a n-ésima linha.

namespace ListaExercicio
{
      class Atividade_02
      {
            static void Main2()
            {
                  Console.Write("Digite um número inteiro n: ");
                  int n = int.Parse(Console.ReadLine());

                  ImprimirPadrao(n);

                  // Evita que o console feche imediatamente
                  Console.WriteLine("Pressione qualquer tecla para sair...");
                  Console.ReadKey();
            }

            static void ImprimirPadrao(int n)
            {
                  for (int i = 1; i <= n; i++)
                  {
                        for (int j = 1; j <= i; j++)
                        {
                              Console.Write(j + " ");
                        }
                        Console.WriteLine();
                  }
            }

      }
}
