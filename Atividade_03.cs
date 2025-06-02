using System;

//3. Faça um programa, com uma função que necessite de três argumentos, e que
//forneça a soma desses três argumentos.

namespace ListaExercicio
{
      class Atividade_03
      {
            static void Main3()
            {
                  int a = LerNumero("Digite o primeiro número: ");
                  int b = LerNumero("Digite o segundo número: ");
                  int c = LerNumero("Digite o terceiro número: ");

                  int resultado = SomarTresNumeros(a, b, c);

                  MostrarResultado(resultado);

                  Console.WriteLine("Pressione qualquer tecla para sair...");
                  Console.ReadKey();
            }

            // Função para ler um número inteiro com mensagem personalizada
            static int LerNumero(string mensagem)
            {
                  Console.Write(mensagem);
                  return int.Parse(Console.ReadLine());
            }

            // Função que recebe três argumentos e retorna a soma
            static int SomarTresNumeros(int x, int y, int z)
            {
                  return x + y + z;
            }

            // Função para exibir o resultado
            static void MostrarResultado(int soma)
            {
                  Console.WriteLine("A soma dos três números é: " + soma);
            }
      }
}
