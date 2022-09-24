using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class EventoC2
    {
        public static void MagoC2()
        {
            BatalhaUnica batalha = new BatalhaUnica();
            Program Mais_DP = new Program();
            if (batalha.C2 == true)
            {
                goto Retorno;
            }
            else
            {
                int inimigohp = 0, hp = 0, hpmax = 0;
                Console.Clear();
                Combate.MagoCombate(ref inimigohp, ref hp, ref hpmax);
                if (hp <= 0)
                {
                    Console.Clear();
                    Interface.Derrota();
                }
                else if (inimigohp <= 0)
                {
                    Mais_DP.Pocao = Mais_DP.Pocao + 1;
                    Mais_DP.Vida = Mais_DP.Vida + 5;
                    batalha.C2 = true;
                    Console.Clear();
                    Bau.eventoBau();
                    goto Retorno;
                }
            }
        Retorno:
            Console.Clear();
            Bau.aberto();
            Console.SetCursorPosition(22, 2); Console.Write("\"O caminho a direita se abre...\"");
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
                    Console.Clear();
                    Cena_C2.movimento_CenaC2();
                    break;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    Cena_C1.movimento_CenaC1();
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
