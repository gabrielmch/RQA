using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class Cena_C1
    {
        public static void movimento_CenaC1()
        {
            BatalhaUnica batalha = new BatalhaUnica();
        Retorno:
            Corredores.EsquerdaCentro();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    Console.Clear();
                    EventoC2.MagoC2();
                    break;
                case ConsoleKey.LeftArrow:
                    if (batalha.C1 == true)
                    {
                        Console.SetCursorPosition(16, 21); Console.Write("\"O monstro desta sala já foi derrotado!\"");
                        Console.SetCursorPosition(18, 22); Console.Write("\"Você se sente mais forte!\"");
                        Thread.Sleep(2000);
                        goto Retorno;
                    }
                    if (batalha.C1 == false)
                    {
                        Console.Clear();
                        EventoC1.AranhaC1();
                    }
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
                    Console.SetCursorPosition(25, 22); Console.Write("\"Sinto que nada ocorreu...\"");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Retorno;
            }
        }
    }
}
