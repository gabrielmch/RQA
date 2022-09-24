using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class UltimoChefe
    {
        public static void Cena1()
        {
            Console.SetCursorPosition(10, 0); Console.Write("\\                                                     /");
            Console.SetCursorPosition(11, 1); Console.Write("\\                                                   /");
            Console.SetCursorPosition(12, 2); Console.Write("\\                                                 /");
            Console.SetCursorPosition(13, 3); Console.Write("\\                                               /");
            Console.SetCursorPosition(14, 4); Console.Write("\\                                             /");
            Console.SetCursorPosition(15, 5); Console.Write("\\                                           /");
            Console.SetCursorPosition(16, 6); Console.Write("\\                                         /");
            Console.SetCursorPosition(17, 7); Console.Write("\\                                       /");
            Console.SetCursorPosition(18, 8); Console.Write("\\_____________________________________/");
            Console.SetCursorPosition(18, 9); Console.Write("|                                     |");
            Console.SetCursorPosition(18, 10); Console.Write("|                                     |");
            Console.SetCursorPosition(18, 11); Console.Write("|                                     |");
            Console.SetCursorPosition(18, 12); Console.Write("|                                     |");
            Console.SetCursorPosition(18, 13); Console.Write("|                                     |");
            Console.SetCursorPosition(18, 14); Console.Write("|_____________________________________|");
            Console.SetCursorPosition(18, 15); Console.Write("/                                     \\");
            Console.SetCursorPosition(17, 16); Console.Write("/                                       \\");
            Console.SetCursorPosition(16, 17); Console.Write("/                                         \\");
            Console.SetCursorPosition(15, 18); Console.Write("/                                           \\");
            Console.SetCursorPosition(14, 19); Console.Write("/                                             \\");
            Console.SetCursorPosition(13, 20); Console.Write("/                                               \\");
            Console.SetCursorPosition(12, 21); Console.Write("/                                                 \\");
            Console.SetCursorPosition(11, 22); Console.Write("/                                                   \\");
            Console.SetCursorPosition(10, 23); Console.Write("/                                                     \\");
        }
        public static void cena2()
        {
            Console.SetCursorPosition(10, 23); Console.Write("/            /                           \\            \\");
            Thread.Sleep(200);
            Console.SetCursorPosition(11, 22); Console.Write("/            /                         \\            \\");
            Thread.Sleep(200);
            Console.SetCursorPosition(12, 21); Console.Write("/            /                       \\            \\");
            Thread.Sleep(200);
            Console.SetCursorPosition(13, 20); Console.Write("/            /                     \\            \\");
            Thread.Sleep(200);
            Console.SetCursorPosition(14, 19); Console.Write("/            /                   \\            \\");
            Thread.Sleep(200);
            Console.SetCursorPosition(15, 18); Console.Write("/            /                 \\            \\");
            Thread.Sleep(200);
            Console.SetCursorPosition(16, 17); Console.Write("/            /               \\            \\");
            Thread.Sleep(200);
            Console.SetCursorPosition(17, 16); Console.Write("/            /             \\            \\");
            Thread.Sleep(200);
            Console.SetCursorPosition(18, 15); Console.Write("/            /           \\            \\");

            Thread.Sleep(400);
            Console.SetCursorPosition(12, 21); Console.Write("/            /_/___________________\\_\\            \\");
            Thread.Sleep(400);
            Console.SetCursorPosition(13, 20); Console.Write("/            / _/_______________\\_ \\            \\");
            Thread.Sleep(400);
            Console.SetCursorPosition(14, 19); Console.Write("/            /  _/___________\\_  \\            \\");
            Thread.Sleep(400);
            Console.SetCursorPosition(15, 18); Console.Write("/            /   _/_______\\_   \\            \\");
            Thread.Sleep(400);
            Console.SetCursorPosition(16, 17); Console.Write("/            /    \\_____/    \\            \\");
            Console.SetCursorPosition(17, 16); Console.Write("/            /  \\       /  \\            \\");
            Console.SetCursorPosition(18, 15); Console.Write("/            /\\         /\\            \\");

        }
        public static void CenaFinal()
        {
            int inimigohp = 0, hp = 0, hpmax = 0;
            UltimoChefe.Cena1();
            Console.SetCursorPosition(24, 11); Console.Write("\"A sala agora se encontra\"");
            Console.SetCursorPosition(23, 12); Console.Write("\"Completamente diferente...\"");
            Thread.Sleep(200);
            Console.SetCursorPosition(34, 13); Console.Write("\"..\"");
            Thread.Sleep(200);
            Console.SetCursorPosition(34, 13); Console.Write("\"...\"");
            Thread.Sleep(200);
            Console.SetCursorPosition(34, 13); Console.Write("\"....\"");
            Thread.Sleep(200);
            Console.SetCursorPosition(34, 13); Console.Write("\".....\"");
            Thread.Sleep(1000);
            Console.Clear();
            UltimoChefe.Cena1();
            Console.SetCursorPosition(22, 12); Console.Write("\"Algo começa a tremer no chão..\"");
            UltimoChefe.cena2();
            Console.Clear();
            Combate.HyndraCombate(ref inimigohp, ref hp, ref hpmax);
            Console.Clear();
            Console.SetCursorPosition(16, 12); Console.Write("\"Você finalmente da um fim nesta masmorra...\"");
            Thread.Sleep(1000);
            System.Environment.Exit(0);
        }
    }
}
