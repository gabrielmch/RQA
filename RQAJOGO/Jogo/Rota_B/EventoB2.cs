using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class EventoB2
    {
        public static void MagoB2()
        {
            BatalhaUnica batalha = new BatalhaUnica();
            Program Mais_DP = new Program();
            if (batalha.B2 == true)
            {
                goto PosEvento;
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
                    Mais_DP.Dano = Mais_DP.Dano + 1;
                    Mais_DP.Vida = Mais_DP.Vida + 5;
                    batalha.B2 = true;
                    Console.Clear();
                    goto PosEvento;
                }
            }
        PosEvento:
            Console.Clear();
            Corredores.Centro();
            Console.SetCursorPosition(18, 21); Console.Write("\"O monstro desta sala foi derrotado!\"");
            Console.SetCursorPosition(22, 22); Console.Write("\"Você se sente mais forte!\"");
            Thread.Sleep(2000);
        Retorno:
            Console.Clear();
            Corredores.Centro();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    Console.Clear();
                    Cena_B3.movimento_CenaB3();
                    break;
                case ConsoleKey.LeftArrow:
                    Console.SetCursorPosition(14, 22); Console.Write("\"Acredito que não a como ir por este caminho..\"");
                    Thread.Sleep(2000);
                    goto Retorno;
                case ConsoleKey.RightArrow:
                    Console.SetCursorPosition(14, 22); Console.Write("\"Acredito que não a como ir por este caminho..\"");
                    Thread.Sleep(2000);
                    goto Retorno;
                case ConsoleKey.DownArrow:
                    Console.Clear();
                    Cena_B2.movimento_CenaB2();
                    break;
                case ConsoleKey.B:
                    Console.Clear();
                    Interface.Perfil();
                    goto Retorno;
                default:
                    Console.SetCursorPosition(16, 22); Console.Write("Sinto que nada ocorreu...");
                    Thread.Sleep(1000);
                    Console.Clear();
                    goto Retorno;
            }
        }
    }
}
