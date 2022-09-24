using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class Cena_A2
    {
        public static void movimento_CenaA2()
        {
            Program items = new Program();
            Corredores.Centro();
            Console.SetCursorPosition(13, 22); Console.Write("\"Algo nesta sala lhe causa uma sensação estranha.\"");
            Thread.Sleep(2000);
            Console.Clear();
        Retorno:
            if ((items.PegarItem1 == true) && (items.PegarItem2 == true) && (items.PegarItem3 == true) )
            {
                Console.Clear();
                UltimoChefe.CenaFinal();
            }
            Corredores.Centro();
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.UpArrow:
                    Console.Clear();
                    Cena_A3.movimento_CenaA3();
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
                    Cena_A1.movimento_CenaA1();
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
