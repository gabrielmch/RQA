using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class Interface
    {
        public static void Perfil()
        {
            Program Var_DP = new Program();
        Menu:
            Console.SetCursorPosition(2, 1); Console.Write("╔");
            Console.SetCursorPosition(2, 22); Console.Write("╚");
            Console.SetCursorPosition(73, 1); Console.Write("╗");
            Console.SetCursorPosition(73, 22); Console.Write("╝");

            for (int i = 3; i <= 72; i++)
            {
                Console.SetCursorPosition(i, 1); Console.Write("═");
                Console.SetCursorPosition(i, 22); Console.Write("═");
            }
            for (int i = 2; i <= 21; i++)
            {
                Console.SetCursorPosition(2, i); Console.Write("║");
                Console.SetCursorPosition(73, i); Console.Write("║");
            }

            Console.SetCursorPosition(20, 3); Console.Write("PAUSADO");
            Console.SetCursorPosition(5, 5); Console.Write("Seta Levantada: Avançar para frente");
            Console.SetCursorPosition(5, 6); Console.Write("Seta Direita:   Avançar para direita");
            Console.SetCursorPosition(5, 7); Console.Write("Seta Esquerda:  Avançar para esquerda");
            Console.SetCursorPosition(5, 8); Console.Write("Seta Caida:     Retorna para trás");

            Console.SetCursorPosition(48, 3); Console.Write("___________________");
            Console.SetCursorPosition(47, 4); Console.Write("/  \\            /   \\");
            Console.SetCursorPosition(46, 5); Console.Write("/                     \\");
            Console.SetCursorPosition(45, 6); Console.Write("/\\      /\\/\\/\\  /      /\\");
            Console.SetCursorPosition(44, 7); Console.Write("/   /\\  /_     \\/_\\  /\\   \\");
            Console.SetCursorPosition(44, 8); Console.Write("\\  /| \\/ |       | \\/ |\\  /");
            Console.SetCursorPosition(45, 9); Console.Write("\\/@| |__|  |    |__| |@\\/");
            Console.SetCursorPosition(48, 10); Console.Write("|       |         |");
            Console.SetCursorPosition(48, 11); Console.Write("|       \\_/       |");
            Console.SetCursorPosition(49, 12); Console.Write("\\               /");
            Console.SetCursorPosition(50, 13); Console.Write("\\             /");
            Console.SetCursorPosition(51, 14); Console.Write("\\___________/");

            if (Var_DP.PegarItem1 == false)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(33, 15); Console.Write("__________");
                Console.SetCursorPosition(32, 16); Console.Write("/          \\");
                Console.SetCursorPosition(32, 17); Console.Write("|          |");
                Console.SetCursorPosition(32, 18); Console.Write("|          |");
                Console.SetCursorPosition(32, 19); Console.Write("|          |");
                Console.SetCursorPosition(32, 20); Console.Write("|          |");
                Console.SetCursorPosition(32, 21); Console.Write("\\__________/");
            }
            else if (Var_DP.PegarItem1 == true)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(33, 15); Console.Write("__________");
                Console.SetCursorPosition(32, 16); Console.Write("/   ____   \\");
                Console.SetCursorPosition(32, 17); Console.Write("|  \\    /  |");
                Console.SetCursorPosition(32, 18); Console.Write("|   \\||/   |");
                Console.SetCursorPosition(32, 19); Console.Write("|   /||\\   |");
                Console.SetCursorPosition(32, 20); Console.Write("|   \\__/   |");
                Console.SetCursorPosition(32, 21); Console.Write("\\__________/");
            }
            if (Var_DP.PegarItem2 == false)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(7, 15); Console.Write("__________");
                Console.SetCursorPosition(6, 16); Console.Write("/          \\");
                Console.SetCursorPosition(6, 17); Console.Write("|          |");
                Console.SetCursorPosition(6, 18); Console.Write("|          |");
                Console.SetCursorPosition(6, 19); Console.Write("|          |");
                Console.SetCursorPosition(6, 20); Console.Write("|          |");
                Console.SetCursorPosition(6, 21); Console.Write("\\__________/");
            }
            else if (Var_DP.PegarItem2 == true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(7, 15); Console.Write("__________");
                Console.SetCursorPosition(6, 16); Console.Write("/          \\");
                Console.SetCursorPosition(6, 17); Console.Write("|  /\\  /\\  |");
                Console.SetCursorPosition(6, 18); Console.Write("|  \\ \\/ /  |");
                Console.SetCursorPosition(6, 19); Console.Write("|  /  \\ \\  |");
                Console.SetCursorPosition(6, 20); Console.Write("|  \\___\\/  |");
                Console.SetCursorPosition(6, 21); Console.Write("\\__________/");
            }

            if (Var_DP.PegarItem3 == false)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(20, 15); Console.Write("__________");
                Console.SetCursorPosition(19, 16); Console.Write("/          \\");
                Console.SetCursorPosition(19, 17); Console.Write("|          |");
                Console.SetCursorPosition(19, 18); Console.Write("|          |");
                Console.SetCursorPosition(19, 19); Console.Write("|          |");
                Console.SetCursorPosition(19, 20); Console.Write("|          |");
                Console.SetCursorPosition(19, 21); Console.Write("\\__________/");
            }
            else if (Var_DP.PegarItem3 == true)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.SetCursorPosition(20, 15); Console.Write("__________");
                Console.SetCursorPosition(19, 16); Console.Write("/          \\");
                Console.SetCursorPosition(19, 17); Console.Write("|   /\\/\\   |");
                Console.SetCursorPosition(19, 18); Console.Write("|  / /\\ \\  |");
                Console.SetCursorPosition(19, 19); Console.Write("|  \\_\\/_/  |");
                Console.SetCursorPosition(19, 20); Console.Write("|   /__\\   |");
                Console.SetCursorPosition(19, 21); Console.Write("\\__________/");
            }
            
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 16); Console.Write("[             ]");
            Console.SetCursorPosition(52, 18); Console.Write("[ {0} ] VIDA", Var_DP.Vida);
            Console.SetCursorPosition(52, 19); Console.Write("[ {0} ] DANO", Var_DP.Dano);
            Console.SetCursorPosition(52, 20); Console.Write("[ {0} ] POÇÕES", Var_DP.Pocao);

            Console.SetCursorPosition(10, 11); Console.Write("[Tab] Abandonar Aventura");
            Console.SetCursorPosition(8, 12); Console.Write("[B] para Retornar à Aventura");
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.B:
                    Console.Clear();
                    break;
                case ConsoleKey.Tab:
                    Console.Clear();
                    Console.WriteLine("S- Para sair\nN- Para retornar ao perfil");
                    if (Console.ReadKey().Key == ConsoleKey.S)
                    {
                        System.Environment.Exit(0);
                        Console.Clear();
                    }
                    if (Console.ReadKey().Key == ConsoleKey.N)
                    {
                        Console.Clear();
                        goto Menu;
                    }
                    else
                        Console.Clear();
                    goto Menu;
                default:
                    Console.Clear();
                    goto Menu;
            }
            Console.SetCursorPosition(30, 13);
        }
        public static void Derrota()
        {
            Console.SetCursorPosition(47, 5); Console.Write("/\\");
            Console.SetCursorPosition(20, 6); Console.Write("\\      /  _____   _____  ______");
            Console.SetCursorPosition(21, 7); Console.Write("\\    /  |     | |      |");
            Console.SetCursorPosition(22, 8); Console.Write("\\  /   |     | |      |-----");
            Console.SetCursorPosition(23, 9); Console.Write("\\/    |_____| |_____ |______");


            Console.ForegroundColor = ConsoleColor.Red;
            Thread.Sleep(150);
            Console.SetCursorPosition(10, 12); Console.Write("______    ________  ______    _____     ________");
            Thread.Sleep(150);
            Console.SetCursorPosition(9, 13); Console.Write("|      \\  |         |      \\  |     \\   |         |       |");
            Thread.Sleep(150);
            Console.SetCursorPosition(9, 14); Console.Write("|       | |         |       | |      \\  |         |       |");
            Thread.Sleep(150);
            Console.SetCursorPosition(9, 15); Console.Write("|______/  |________ |      /  |       | |________ |       |");
            Thread.Sleep(150);
            Console.SetCursorPosition(9, 16); Console.Write("|         |         |     \\   |       | |         |       |");
            Thread.Sleep(150);
            Console.SetCursorPosition(9, 17); Console.Write("|         |         |      \\  |      /  |         |       |");
            Thread.Sleep(150);
            Console.SetCursorPosition(9, 18); Console.Write("|         |________ |       \\ |_____/   |________ \\_______/");
        }
    }
}
