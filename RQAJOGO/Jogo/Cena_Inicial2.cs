using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class Cena_Inicial2
    {
        public static void movimento_CenaInicial2()
        {
        Retorno:
            Corredores.EsquerdaCentroDireita();
            
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    Console.Clear();
                    Cena_B1.movimento_CenaB1();
                    break;
                case ConsoleKey.LeftArrow:
                    Console.Clear();
                    Cena_C1.movimento_CenaC1();
                    break;
                case ConsoleKey.RightArrow:
                    Console.Clear();
                    Cena_A1.movimento_CenaA1();
                    break;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    Cena_Inicial.movimento_CenaInicial();
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
