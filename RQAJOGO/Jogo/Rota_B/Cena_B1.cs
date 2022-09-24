using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class Cena_B1
    {
        public static void movimento_CenaB1()
        {
        Retorno:
            Corredores.EsquerdaCentro();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    Console.Clear();
                    EventoB1.ServoB1();
                    break;
                case ConsoleKey.LeftArrow:
                    Console.Clear();
                    Cena_B2.movimento_CenaB2();
                    break;
                case ConsoleKey.RightArrow:
                    Console.SetCursorPosition(14, 22); Console.Write("\"Acredito que não a como ir por este caminho..\"");
                    Thread.Sleep(2000);
                    goto Retorno;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    Cena_Inicial2.movimento_CenaInicial2();
                    break;
                case ConsoleKey.B:
                    Console.Clear();
                    Interface.Perfil();
                    goto Retorno;
                default:
                    Console.SetCursorPosition(25, 22); Console.Write("Sinto que nada ocorreu...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Retorno;
            }
        }
    }
}
