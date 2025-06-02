using System;

//4. Faça um programa, com uma função que necessite de um argumento.A
//função retorna o valor de caractere ‘P’, se seu argumento for positivo, e ‘N’, se
//seu argumento for zero ou negativo.

namespace ListaExercicio
{
      class Atividade_04
      {
            static void Main4()
            {
                  Console.Write("Digite um número inteiro: ");
                  int numero = int.Parse(Console.ReadLine());

                  char resultado = VerificarPositivoOuNegativo(numero);

                  Console.WriteLine("Resultado: " + resultado);

                  Console.WriteLine("Pressione qualquer tecla para sair...");
                  Console.ReadKey();
            }

            // Função que retorna 'P' se positivo, 'N' se zero ou negativo
            static char VerificarPositivoOuNegativo(int valor)
            {
                  if (valor > 0)
                        return 'P';
                  else
                        return 'N';
            }

      }
}
