using System;

//1. Faça um programa para imprimir:
//1
//2 2
//3 3 3
//.....
//n n n n n n...n
//para um n informado pelo usuário.
//Use uma função que receba um valor n inteiro e imprima até a n-ésima linha.

namespace ListaExercicio_VIII
{
      class Atividade_01
      {
            static void Main()
            {
                  Console.Write("Digite um número inteiro: ");
                  int n = int.Parse(Console.ReadLine());

                  ImprimirPadrao(n);

                  // Espera o usuário pressionar uma tecla antes de fechar
                  Console.WriteLine("Pressione qualquer tecla para sair...");
                  Console.ReadKey();
            }

            static void ImprimirPadrao(int n)
            {
                  for (int i = 1; i <= n; i++)
                  {
                        for (int j = 1; j <= i; j++)
                        {
                              Console.Write(i + " ");
                        }
                        Console.WriteLine();
                  }
            }
      }


}

