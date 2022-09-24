using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using DungeonProj_FECIP_2020;

namespace RQAJOGO
{
    class Cena_C3
    {
        public static void movimento_CenaC3()
        {
            BatalhaUnica batalha = new BatalhaUnica();
            Program Mais_DP = new Program();
        Retorno:
            Corredores.Esquerda();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    Console.SetCursorPosition(14, 22); Console.Write("\"Acredito que não a como ir por este caminho..\"");
                    Thread.Sleep(2000);
                    goto Retorno;
                case ConsoleKey.LeftArrow:
                    if (Mais_DP.Vida <= 29)
                    {
                        Console.SetCursorPosition(14, 21); Console.Write("\"Você não possui vida o suficiente para lutar.\"");
                        Thread.Sleep(2000);
                        goto Retorno;
                    }
                    if (batalha.Chefec == true)
                    {
                        Console.SetCursorPosition(25, 21); Console.Write("\"Sala do Malos...\"");
                        Thread.Sleep(2000);
                        goto Retorno;
                    }
                    if (batalha.Chefec == false)
                    {
                        Console.Clear();
                        EventoChefeC.ChefeC();
                    }
                    break;
                case ConsoleKey.RightArrow:
                    Console.SetCursorPosition(14, 22); Console.Write("\"Acredito que não a como ir por este caminho..\"");
                    Thread.Sleep(2000);
                    goto Retorno;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    Cena_C2.movimento_CenaC2();
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
