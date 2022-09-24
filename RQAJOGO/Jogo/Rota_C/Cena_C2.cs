using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class Cena_C2
    {
        
        public static void movimento_CenaC2()
        {
        BatalhaUnica batalha = new BatalhaUnica();
        Retorno:
            Corredores.EsquerdaCentro();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    Console.Clear();
                    Cena_C3.movimento_CenaC3();
                    break;
                case ConsoleKey.LeftArrow:
                    if (batalha.C3 == true)
                    {
                        Console.SetCursorPosition(16, 21); Console.Write("\"O monstro desta sala já foi derrotado!\"");
                        Console.SetCursorPosition(18, 22); Console.Write("\"Você se sente mais forte!\"");
                        Thread.Sleep(2000);
                        goto Retorno;
                    }
                    if (batalha.C3 == false)
                    {
                        Console.Clear();
                        EventoC3.ServoC3();
                    }
                    break;
                case ConsoleKey.RightArrow:
                    Console.SetCursorPosition(14, 22); Console.Write("\"Acredito que não a como ir por este caminho..\"");
                    Thread.Sleep(2000);
                    goto Retorno;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    EventoC2.MagoC2();
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
