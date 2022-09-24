using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using DungeonProj_FECIP_2020;

namespace RQAJOGO
{
    class Cena_A4
    {
        public static void movimento_CenaA4()
        {
            BatalhaUnica batalha = new BatalhaUnica();
            Program Mais_DP = new Program();
        Retorno:
            Corredores.EsquerdaCentroDireita();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    if (batalha.A3 == true)
                    {
                        Console.SetCursorPosition(16, 21); Console.Write("\"O monstro desta sala já foi derrotado!\"");
                        Console.SetCursorPosition(18, 22); Console.Write("\"Você se sente mais forte!\"");
                        Thread.Sleep(2000);
                        goto Retorno;
                    }
                    if (batalha.A3 == false)
                    {
                        Console.Clear();
                        EventoA3.AranhaA3();
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (Mais_DP.Vida <= 29)
                    {
                        Console.SetCursorPosition(14, 21); Console.Write("\"Você não possui vida o suficiente para lutar.\"");
                        Thread.Sleep(2000);
                        goto Retorno;
                    }
                    if (batalha.Chefea == true)
                    {
                        Console.SetCursorPosition(25, 21); Console.Write("\"Sala do Argos.\"");
                        Thread.Sleep(2000);
                        goto Retorno;
                    }
                    if (batalha.Chefea == false)
                    {
                        Console.Clear();
                        EventoChefeA.ChefeA();
                    }
                    break;
                case ConsoleKey.RightArrow:
                    Console.Clear();
                    EventoA2.ServoA2();
                    break;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    Cena_A3.movimento_CenaA3();
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
