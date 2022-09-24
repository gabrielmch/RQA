using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using RQAJOGO;

namespace RQAJOGO
{
    class EventoChefeC
    {
        public static void ChefeC()
        {
            Console.Clear();
            Chefes.ChefeC_anima();
            Chefes.ChefeC();
            Console.ForegroundColor = ConsoleColor.White;
            BatalhaUnica batalha = new BatalhaUnica();
            Program Mais_DP = new Program();
            int inimigohp = 0, hp = 0, hpmax = 0;
            Console.Clear();
            Combate.MalosCombate(ref inimigohp, ref hp, ref hpmax);
            if (hp <= 0)
            {
                Console.Clear();
                Interface.Derrota();
            }
            else if (inimigohp <= 0)
            {
                Mais_DP.PegarItem3 = true;
                batalha.Chefec = true;
                Console.Clear();
                Cena_Inicial2.movimento_CenaInicial2();
            }
        }
    }
}
