using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class Abertura
    {
        public static void Inicializacao()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Thread.Sleep(150);
            Console.SetCursorPosition(18, 2); Console.Write("_____          O         _____   ______");
            Thread.Sleep(150);
            Console.SetCursorPosition(17, 3); Console.Write("|     \\ |     | | |\\   | /     \\ /");
            Thread.Sleep(150);
            Console.SetCursorPosition(17, 4); Console.Write("|     | |     | | | \\  | |_____| \\_____");
            Thread.Sleep(150);
            Console.SetCursorPosition(17, 5); Console.Write("|    /  |     | | |  \\ | |     |       \\");
            Thread.Sleep(150);
            Console.SetCursorPosition(17, 6); Console.Write("|    \\  \\_____/ | |   \\| |     | ______/");
            Thread.Sleep(150);

            Console.SetCursorPosition(19, 7); Console.Write("____    _____   _____");
            Thread.Sleep(150);
            Console.SetCursorPosition(18, 8); Console.Write("|    \\  /     \\ /           | \\      /");
            Thread.Sleep(150);
            Console.SetCursorPosition(18, 9); Console.Write("|     | |     | \\_____      |  \\    / ");
            Thread.Sleep(150);
            Console.SetCursorPosition(18, 10); Console.Write("|     | |     |       \\     |   \\  /");
            Thread.Sleep(150);
            Console.SetCursorPosition(18, 11); Console.Write("|____/  \\_____/ ______/     |    \\/");

            Console.ForegroundColor = ConsoleColor.Cyan;
            Thread.Sleep(150);
            Console.SetCursorPosition(7, 12); Console.Write("_____   _____   ______  _____         _______  ______  ______");
            Thread.Sleep(150);
            Console.SetCursorPosition(6, 13); Console.Write("/     \\ |     \\ /       /     \\ |\\   |    |    /       /");
            Thread.Sleep(150);
            Console.SetCursorPosition(6, 14); Console.Write("|_____| |     | |       |     | | \\  |    |    |_____  \\_____");
            Thread.Sleep(150);
            Console.SetCursorPosition(6, 15); Console.Write("|     | |    /  |       |     | |  \\ |    |    |             \\");
            Thread.Sleep(150);
            Console.SetCursorPosition(6, 16); Console.Write("|     | |    \\  \\______ \\_____/ |   \\|    |    \\______ ______/");
            Thread.Sleep(1000);

            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(32, 19); Console.Write("CARREGANDO");
            Console.SetCursorPosition(18, 20); Console.Write("[                                    ]");
            Thread.Sleep(200);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(19, 20); Console.Write("||");
            Thread.Sleep(200);
            Console.SetCursorPosition(19, 20); Console.Write("||||");
            Thread.Sleep(200);
            Console.SetCursorPosition(19, 20); Console.Write("||||||");
            Thread.Sleep(200);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||");
            Thread.Sleep(200);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||");
            Thread.Sleep(440);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||||");
            Thread.Sleep(200);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||||||");
            Thread.Sleep(670);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||||||||");
            Thread.Sleep(200);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||||||||||");
            Thread.Sleep(200);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||||||||||||");
            Thread.Sleep(200);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||||||||||||||");
            Thread.Sleep(500);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||||||||||||||||");
            Thread.Sleep(550);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||||||||||||||||||");
            Thread.Sleep(200);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||||||||||||||||||||");
            Thread.Sleep(200);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||||||||||||||||||||||");
            Thread.Sleep(400);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||||||||||||||||||||||||");
            Thread.Sleep(200);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||||||||||||||||||||||||||");
            Thread.Sleep(250);
            Console.SetCursorPosition(19, 20); Console.Write("||||||||||||||||||||||||||||||||||||");

            Thread.Sleep(2000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void Menu()
        {
            Console.SetCursorPosition(28, 2); Console.Write("_____   ____   _____");
            Console.SetCursorPosition(27, 3); Console.Write("|     \\ /    \\ /     \\");
            Console.SetCursorPosition(27, 4); Console.Write("|     | |    | |_____|");
            Console.SetCursorPosition(27, 5); Console.Write("|    /  |   \\| |     |");
            Console.SetCursorPosition(27, 6); Console.Write("|    \\  \\____\\ |     |");

            Console.SetCursorPosition(31, 8); Console.Write("_____________");
            Console.SetCursorPosition(30, 9); Console.Write("/             \\");
            Console.SetCursorPosition(30, 10); Console.Write("    INICIAR    ");
            Console.SetCursorPosition(30, 11); Console.Write("\\_____________/");

            Console.SetCursorPosition(31, 12); Console.Write("_____________");
            Console.SetCursorPosition(30, 13); Console.Write("/             \\");
            Console.SetCursorPosition(30, 14); Console.Write("     SOBRE    ");
            Console.SetCursorPosition(30, 15); Console.Write("\\_____________/");

            Console.SetCursorPosition(31, 16); Console.Write("_____________");
            Console.SetCursorPosition(30, 17); Console.Write("/             \\");
            Console.SetCursorPosition(30, 18); Console.Write("     SAIR   ");
            Console.SetCursorPosition(30, 19); Console.Write("\\_____________/");

            Console.SetCursorPosition(1, 23); Console.Write("Ruínas dos IV Arcontes 2020,     Gabriel M. & Lukas O.,       Versão 1.0.0");
        }
        public static void Sobre()
        {
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

            Console.SetCursorPosition(34, 3); Console.Write("PRODUÇÃO");
            Console.SetCursorPosition(24, 4); Console.Write("════════════════════════════");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(35, 5); Console.Write("DESIGN");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(30, 6); Console.Write("GABRIEL MICHAELI");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(33, 7); Console.Write("PROGRAMAÇÃO");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(30, 8); Console.Write("GABRIEL MICHAELI");
            Console.SetCursorPosition(31, 9); Console.Write("LUKAS OCTÁVIO");
            Console.SetCursorPosition(24, 15); Console.Write("════════════════════════════");

            Console.SetCursorPosition(32, 16); Console.Write("____________");
            Console.SetCursorPosition(31, 17); Console.Write("/            \\");
            Console.SetCursorPosition(31, 18); Console.Write("   RETORNAR  ");
            Console.SetCursorPosition(31, 19); Console.Write("\\____________/");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(31, 18); Console.Write(">");
            Console.SetCursorPosition(44, 18); Console.Write("<");

            if(Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Abertura.MenuLogica();
            }
        }
        public static void MenuLogica()
        {
            ConsoleKeyInfo Tecla;
            do
            {
            Menu:
                //iniciar
                Abertura.Menu();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(30, 10); Console.Write(">");
                Console.SetCursorPosition(44, 10); Console.Write("<");
                Console.ForegroundColor = ConsoleColor.White;
                Tecla = Console.ReadKey();
                //jogo
                if (Tecla.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Cena_Inicial.movimento_CenaInicial();
                }
                //sobre
                if (Tecla.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    Abertura.Menu();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(30, 14); Console.Write(">");
                    Console.SetCursorPosition(44, 14); Console.Write("<");
                    Console.ForegroundColor = ConsoleColor.White;
                    Tecla = Console.ReadKey();
                    //layout sobre
                    if (Tecla.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Abertura.Sobre();
                    }
                    //sair
                    if (Tecla.Key == ConsoleKey.DownArrow)
                    {
                    Menu2:
                        Console.Clear();
                        Abertura.Menu();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(30, 18); Console.Write(">");
                        Console.SetCursorPosition(44, 18); Console.Write("<");
                        Console.ForegroundColor = ConsoleColor.White;
                        Tecla = Console.ReadKey();
                        //sobre
                        if (Tecla.Key == ConsoleKey.UpArrow)
                        {
                            Console.Clear();
                            Abertura.Menu();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.SetCursorPosition(30, 14); Console.Write(">");
                            Console.SetCursorPosition(44, 14); Console.Write("<");
                            Console.ForegroundColor = ConsoleColor.White;
                            Tecla = Console.ReadKey();
                            //layout sobre
                            if (Tecla.Key == ConsoleKey.Enter)
                            {
                                Console.Clear();
                                Abertura.Sobre();
                            }
                            //iniciar
                            if (Tecla.Key == ConsoleKey.UpArrow)
                            {
                                Console.Clear();
                                goto Menu;
                            }
                            //sair
                            if (Tecla.Key == ConsoleKey.DownArrow)
                            {
                                Console.Clear();
                                goto Menu2;
                            }
                        }
                        //iniciar
                        if (Tecla.Key == ConsoleKey.DownArrow)
                        {
                            Console.Clear();
                            goto Menu;
                        }
                    }
                    //iniciar
                    if (Tecla.Key == ConsoleKey.UpArrow)
                    {
                        Console.Clear();
                        goto Menu;
                    }
                }
                //sair
                if (Tecla.Key == ConsoleKey.UpArrow)
                {
                Menu2:
                    Console.Clear();
                    Abertura.Menu();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.SetCursorPosition(30, 18); Console.Write(">");
                    Console.SetCursorPosition(44, 18); Console.Write("<");
                    Console.ForegroundColor = ConsoleColor.White;
                    Tecla = Console.ReadKey();
                    //sobre
                    if (Tecla.Key == ConsoleKey.UpArrow)
                    {
                        Console.Clear();
                        Abertura.Menu();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.SetCursorPosition(30, 14); Console.Write(">");
                        Console.SetCursorPosition(44, 14); Console.Write("<");
                        Console.ForegroundColor = ConsoleColor.White;
                        Tecla = Console.ReadKey();
                        //layout sobre
                        if (Tecla.Key == ConsoleKey.Enter)
                        {
                            Console.Clear();
                            Abertura.Sobre();
                        }
                        //iniciar
                        if (Tecla.Key == ConsoleKey.UpArrow)
                        {
                            Console.Clear();
                            goto Menu;
                        }
                        //sair
                        if (Tecla.Key == ConsoleKey.DownArrow)
                        {
                            Console.Clear();
                            goto Menu2;
                        }
                    }
                    //iniciar
                    if (Tecla.Key == ConsoleKey.DownArrow)
                    {
                        Console.Clear();
                        goto Menu;
                    }
                }
            } while (Tecla.Key != ConsoleKey.Enter);
        }
    }
}
