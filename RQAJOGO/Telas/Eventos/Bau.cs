using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class Bau
    {
        public static void eventoBau()
        {
            Console.SetCursorPosition(20, 7); Console.Write("______________________________");
            Console.SetCursorPosition(19, 8); Console.Write("|\\                             \\");
            Console.SetCursorPosition(19, 9); Console.Write("|\"\\                             \\");
            Console.SetCursorPosition(19, 10); Console.Write("|\"\"\\_____________________________\\");
            Console.SetCursorPosition(19, 11); Console.Write("|\\\"\"|    ||                 ||    | ");
            Console.SetCursorPosition(19, 12); Console.Write("|\"\\\"|    ||      ______     ||    |");
            Console.SetCursorPosition(19, 13); Console.Write("|\"\"\\|____||_____|__{}__|____||____|");
            Console.SetCursorPosition(19, 14); Console.Write("|\"\"|     ||     |  ||  |    ||    |");
            Console.SetCursorPosition(19, 15); Console.Write("|\"\"|     ||     |______|    ||    |");
            Console.SetCursorPosition(19, 16); Console.Write("|\"\"|     ||                 ||    |");
            Console.SetCursorPosition(20, 17); Console.Write("\\\"|     ||                 ||    |");
            Console.SetCursorPosition(21, 18); Console.Write("\\|_____||_________________||____|");

            Console.SetCursorPosition(8, 20); Console.Write("Após este combate o monstro libera a passagem para um baú...");
            Thread.Sleep(900);
            Console.SetCursorPosition(35, 21); Console.Write(".");
            Thread.Sleep(900);
            Console.SetCursorPosition(35, 21); Console.Write("..");
            Thread.Sleep(900);
            Console.SetCursorPosition(35, 21); Console.Write("...");
            Thread.Sleep(900);
            Console.SetCursorPosition(35, 21); Console.Write("....");

            Thread.Sleep(2000);
            Console.Clear();
            Console.SetCursorPosition(24, 4); Console.Write("____________________________");
            Console.SetCursorPosition(23, 5); Console.Write("/|   ||                 ||   |");
            Console.SetCursorPosition(22, 6); Console.Write("/\"|   ||      ______     ||    |");
            Console.SetCursorPosition(21, 7); Console.Write("/\"\"|___||_____|__{}__|____||_____|");
            Console.SetCursorPosition(20, 8); Console.Write("/\"\"/                             /");
            Console.SetCursorPosition(19, 9); Console.Write("|\"\"/                             /");
            Console.SetCursorPosition(19, 10); Console.Write("|\"/_____________________________/");
            Console.SetCursorPosition(19, 11); Console.Write("|\\                              \\");
            Console.SetCursorPosition(19, 12); Console.Write("|\"\\                              \\");
            Console.SetCursorPosition(19, 13); Console.Write("|\"\"\\______________________________\\");
            Console.SetCursorPosition(19, 14); Console.Write("|\"\"|     ||     |  ||  |    ||    |");
            Console.SetCursorPosition(19, 15); Console.Write("|\"\"|     ||     |______|    ||    |");
            Console.SetCursorPosition(19, 16); Console.Write("|\"\"|     ||                 ||    |");
            Console.SetCursorPosition(20, 17); Console.Write("\\\"|     ||                 ||    |");
            Console.SetCursorPosition(21, 18); Console.Write("\\|_____||_________________||____|");
            
            Console.SetCursorPosition(23, 20); Console.Write("O Baú continha algumas poções!");
            Thread.Sleep(4000);

        }
        public static void fechado()
        {
            Console.SetCursorPosition(20, 7); Console.Write("______________________________");
            Console.SetCursorPosition(19, 8); Console.Write("|\\                             \\");
            Console.SetCursorPosition(19, 9); Console.Write("|\"\\                             \\");
            Console.SetCursorPosition(19, 10); Console.Write("|\"\"\\_____________________________\\");
            Console.SetCursorPosition(19, 11); Console.Write("|\\\"\"|    ||                 ||    | ");
            Console.SetCursorPosition(19, 12); Console.Write("|\"\\\"|    ||      ______     ||    |");
            Console.SetCursorPosition(19, 13); Console.Write("|\"\"\\|____||_____|__{}__|____||____|");
            Console.SetCursorPosition(19, 14); Console.Write("|\"\"|     ||     |  ||  |    ||    |");
            Console.SetCursorPosition(19, 15); Console.Write("|\"\"|     ||     |______|    ||    |");
            Console.SetCursorPosition(19, 16); Console.Write("|\"\"|     ||                 ||    |");
            Console.SetCursorPosition(20, 17); Console.Write("\\\"|     ||                 ||    |");
            Console.SetCursorPosition(21, 18); Console.Write("\\|_____||_________________||____|");
        }
        public static void aberto()
        {
            Console.SetCursorPosition(24, 4); Console.Write("____________________________");
            Console.SetCursorPosition(23, 5); Console.Write("/|   ||                 ||   |");
            Console.SetCursorPosition(22, 6); Console.Write("/\"|   ||      ______     ||    |");
            Console.SetCursorPosition(21, 7); Console.Write("/\"\"|___||_____|__{}__|____||_____|");
            Console.SetCursorPosition(20, 8); Console.Write("/\"\"/                             /");
            Console.SetCursorPosition(19, 9); Console.Write("|\"\"/                             /");
            Console.SetCursorPosition(19, 10); Console.Write("|\"/_____________________________/");
            Console.SetCursorPosition(19, 11); Console.Write("|\\                              \\");
            Console.SetCursorPosition(19, 12); Console.Write("|\"\\                              \\");
            Console.SetCursorPosition(19, 13); Console.Write("|\"\"\\______________________________\\");
            Console.SetCursorPosition(19, 14); Console.Write("|\"\"|     ||     |  ||  |    ||    |");
            Console.SetCursorPosition(19, 15); Console.Write("|\"\"|     ||     |______|    ||    |");
            Console.SetCursorPosition(19, 16); Console.Write("|\"\"|     ||                 ||    |");
            Console.SetCursorPosition(20, 17); Console.Write("\\\"|     ||                 ||    |");
            Console.SetCursorPosition(21, 18); Console.Write("\\|_____||_________________||____|");
        }
    }
}
