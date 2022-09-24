using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class EventoA3
    {
        public static void AranhaA3()
        {
            BatalhaUnica batalha = new BatalhaUnica();
            Program Mais_DP = new Program();
                int inimigohp = 0, hp = 0, hpmax = 0;
                Console.Clear();
                Combate.AranhaCombate(ref inimigohp, ref hp, ref hpmax);
                if (hp <= 0)
                {
                    Console.Clear();
                Interface.Derrota();
                }
                else if (inimigohp <= 0)
                {
                    Mais_DP.Dano = Mais_DP.Dano + 1;
                    Mais_DP.Vida = Mais_DP.Vida + 5;
                    batalha.A3 = true;
                    Console.Clear();
                    Cena_A4.movimento_CenaA4();
                }
        }
    }
}
