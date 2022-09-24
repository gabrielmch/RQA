using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using DungeonProj_FECIP_2020;

namespace RQAJOGO
{
    class EventoB1
    {
        public static void ServoB1()
        {
            BatalhaUnica batalha = new BatalhaUnica();
            Program Mais_DP = new Program();
            if (batalha.B1 == true)
            {
                goto Retorno;
            }
            else
            {
                int inimigohp = 0, hp = 0, hpmax = 0;
                Console.Clear();
                Combate.ServoCombate(ref inimigohp, ref hp, ref hpmax);
                if (hp <= 0)
                {
                    Console.Clear();
                    Interface.Derrota();
                }
                else if (inimigohp <= 0)
                {
                    Mais_DP.Pocao = Mais_DP.Pocao + 1;
                    Mais_DP.Vida = Mais_DP.Vida + 5;
                    batalha.B1 = true;
                    Console.Clear();
                    Bau.eventoBau();
                    goto Retorno;
                }
            }
        Retorno:
            Console.Clear();
            Bau.aberto();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    Console.SetCursorPosition(22, 20); Console.Write("\"Não precisa se aproximar\"");
                    Thread.Sleep(2000);
                    goto Retorno;
                case ConsoleKey.LeftArrow:
                    Console.SetCursorPosition(22, 20); Console.Write("\"Não existe nada por ali\"");
                    Thread.Sleep(2000);
                    goto Retorno;
                case ConsoleKey.RightArrow:
                    Console.SetCursorPosition(22, 20); Console.Write("\"Não existe nada por ali\"");
                    Thread.Sleep(2000);
                    goto Retorno;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    Cena_B1.movimento_CenaB1();
                    break;
                case ConsoleKey.B:
                    Console.Clear();
                    Interface.Perfil();
                    goto Retorno;
                default:
                    Console.SetCursorPosition(16, 22); Console.Write("\"Sinto que nada ocorreu...\"");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Retorno;
            }
        }
    }
}
