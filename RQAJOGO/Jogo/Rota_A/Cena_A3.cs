using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class Cena_A3
    {
        public static void movimento_CenaA3()
        {
        Retorno:
            Corredores.Direita();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    Console.SetCursorPosition(14, 22); Console.Write("\"Acredito que não a como ir por este caminho..\"");
                    Thread.Sleep(2000);
                    goto Retorno;
                case ConsoleKey.LeftArrow:
                    Console.SetCursorPosition(14, 22); Console.Write("\"Acredito que não a como ir por este caminho..\"");
                    Thread.Sleep(2000);
                    goto Retorno;
                case ConsoleKey.RightArrow:
                    Console.Clear();
                    Cena_A4.movimento_CenaA4();
                    break;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    Cena_A2.movimento_CenaA2();
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
