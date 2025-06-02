using System;

//6. Faça um programa que converta da notação de 24 horas para a notação de 12
//horas.Por exemplo, o programa deve converter 14:25 em 2:25 P.M.A entrada
//é dada em dois inteiros.Deve haver pelo menos duas funções: uma para fazer
//a conversão e uma para a saída.Registre a informação A.M./P.M.como um
//valor ‘A’ para A.M.e ‘P’ para P.M.Assim, a função para efetuar as conversões
//terá um parâmetro formal para registrar se é A.M.ou P.M.Inclua um loop que
//permita que o usuário repita esse cálculo para novos valores de entrada todas
//as vezes que desejar.

namespace ListaExercicio
{
      class Atividade_06
      {
            static void Main6()
            {
                  char repetir;

                  do
                  {
                        Console.Write("Digite a hora (0 a 23): ");
                        int hora = int.Parse(Console.ReadLine());

                        Console.Write("Digite os minutos (0 a 59): ");
                        int minutos = int.Parse(Console.ReadLine());

                        char periodo;
                        int hora12 = ConverterPara12Horas(hora, out periodo);

                        ExibirHora12Horas(hora12, minutos, periodo);

                        Console.Write("Deseja converter outra hora? (S/N): ");
                        repetir = char.ToUpper(Console.ReadKey().KeyChar);
                        Console.WriteLine();

                  } while (repetir == 'S');

                  Console.WriteLine("Programa encerrado.");
            }

            // Função que converte de 24h para 12h e define A.M. ou P.M.
            static int ConverterPara12Horas(int hora24, out char periodo)
            {
                  if (hora24 == 0)
                  {
                        periodo = 'A';
                        return 12;
                  }
                  else if (hora24 == 12)
                  {
                        periodo = 'P';
                        return 12;
                  }
                  else if (hora24 > 12)
                  {
                        periodo = 'P';
                        return hora24 - 12;
                  }
                  else
                  {
                        periodo = 'A';
                        return hora24;
                  }
            }

            // Função que exibe a hora no formato 12h com A.M./P.M.
            static void ExibirHora12Horas(int hora, int minutos, char periodo)
            {
                  string sufixo = (periodo == 'A') ? "A.M." : "P.M.";
                  Console.WriteLine($"Hora convertida: {hora}:{minutos:D2} {sufixo}");
            }

      }
}
