using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using DungeonProj_FECIP_2020;

namespace RQAJOGO
{
    class EventoC3
    {
        public static void ServoC3()
        {
            BatalhaUnica batalha = new BatalhaUnica();
            Program Mais_DP = new Program();
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
                Mais_DP.Dano = Mais_DP.Dano + 1;
                Mais_DP.Vida = Mais_DP.Vida + 5;
                batalha.C3 = true;
                Console.Clear();
                Cena_C2.movimento_CenaC2();
            }
        }
    }
}
