using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using RQAJOGO;

namespace DungeonProj_FECIP_2020
{
    class EventoChefeB
    {
        public static void ChefeB()
        {
            Console.Clear();
            Chefes.ChefeB_anima();
            Chefes.ChefeB();
            Console.ForegroundColor = ConsoleColor.White;
            BatalhaUnica batalha = new BatalhaUnica();
            Program Mais_DP = new Program();
            int inimigohp = 0, hp = 0, hpmax = 0;
            Console.Clear();
            Combate.ValosCombate(ref inimigohp, ref hp, ref hpmax);
            if (hp <= 0)
            {
                Console.Clear();
                Interface.Derrota();
            }
            else if (inimigohp <= 0)
            {
                Mais_DP.PegarItem2 = true;
                batalha.Chefeb = true;
                Console.Clear();
                Cena_Inicial2.movimento_CenaInicial2();
            }
        }
    }
}
