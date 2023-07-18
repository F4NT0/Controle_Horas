using System;

namespace ControleHoras
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * VARIÁVEIS GLOBAIS
             */
            var intervalo = new TimeSpan(1, 0, 0); // 1 hora de intervalo por dia
            var horasPorDia = new TimeSpan(8, 48, 0); // tempo de trabalho são 8 horas e 48 minutos por dia
            var tempoMaximo = new TimeSpan(10, 0, 0); // 10 horas são o tempo máximo por dia

            /**
             * QUADROS UNICODES
             */
            string esqacima = "\u250C";
            string diracima = "\u2510";
            string esqabaixo = "\u2514";
            string dirabaixo = "\u2518";
            string connect = "\u2500";

            Console.Write("> Insira o horário de inicio (ex: 7:00) : ");
            #pragma warning disable CS8600 // faz ignorar warning de variável não inicializada
            string entrada = Console.ReadLine();
            #pragma warning disable CS8602
            bool isEntradaValida = entrada.Contains(":");

            if(isEntradaValida){
                #pragma warning disable CS8602 // faz ignorar warning de variável não inicializada
                string[] entradaSplit = entrada.Split(':'); // hora e minuto de entrada separados
                
                var horarioInicial = new TimeSpan(Int32.Parse(entradaSplit[0]), Int32.Parse(entradaSplit[1]), 0);

                // quadro com os retornos
                Console.WriteLine($"{esqacima}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{diracima}");
                Console.WriteLine($"| Horário de trabalho por dia: {horasPorDia}    |");
                Console.WriteLine($"| Tempo de intervalo: {intervalo}             |");
                Console.Write($"| Horário inicial de entrada: ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write($"{horarioInicial}");
                Console.ResetColor();
                Console.Write("     |\n");
                Console.WriteLine($"{esqabaixo}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{dirabaixo}");
                Console.WriteLine("\n");


                // Cálculo de hora esperada de saída
                var esperado = horarioInicial + intervalo + horasPorDia;

                // Cálculo de hora máxima de saída
                var maximo = horarioInicial + tempoMaximo + intervalo;

                // quadro com os retornos dos horários
                Console.WriteLine($"{esqacima}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{diracima}");
                Console.Write($"| SAÍDA ESPERADA DO DIA: ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"{esperado}");
                Console.ResetColor();
                Console.Write(" |\n");
                Console.Write($"| SAÍDA MÁXIMA DO DIA: ");
                Console.ForegroundColor= ConsoleColor.Yellow;
                Console.Write($"{maximo}");
                Console.ResetColor();
                Console.Write("   |\n");
                Console.WriteLine($"{esqabaixo}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{connect}{dirabaixo}");
            }
            else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("X");
                Console.ResetColor();
                Console.WriteLine(" ERRO: Insira um horário válido!");
            }
        }
    }
}
