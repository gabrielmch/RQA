using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;
using DungeonProj_FECIP_2020;

namespace RQAJOGO
{
    class Combate
    {
        public static void Escolhas()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(6, 14); Console.Write("[Z]");
            Console.SetCursorPosition(3, 15); Console.Write("__________");
            Console.SetCursorPosition(2, 16); Console.Write("/          \\");
            Console.SetCursorPosition(2, 17); Console.Write("|     /\\   |");
            Console.SetCursorPosition(2, 18); Console.Write("|    / /   |");
            Console.SetCursorPosition(2, 19); Console.Write("| __/_/__  |");
            Console.SetCursorPosition(2, 20); Console.Write("|  /_/     |");
            Console.SetCursorPosition(2, 21); Console.Write("\\__________/");
            Console.SetCursorPosition(4, 22); Console.Write("[ATACAR]");

            Console.SetCursorPosition(19, 14); Console.Write("[X]");
            Console.SetCursorPosition(16, 15); Console.Write("__________");
            Console.SetCursorPosition(15, 16); Console.Write("/  ______  \\");
            Console.SetCursorPosition(15, 17); Console.Write("| /      \\ |");
            Console.SetCursorPosition(15, 18); Console.Write("| | ==== | |");
            Console.SetCursorPosition(15, 19); Console.Write("| | ==== | |");
            Console.SetCursorPosition(15, 20); Console.Write("| \\______/ |");
            Console.SetCursorPosition(15, 21); Console.Write("\\__________/");
            Console.SetCursorPosition(17, 22); Console.Write("[DEFESA]");

            Console.SetCursorPosition(32, 14); Console.Write("[C]");
            Console.SetCursorPosition(29, 15); Console.Write("__________");
            Console.SetCursorPosition(28, 16); Console.Write("/    __    \\");
            Console.SetCursorPosition(28, 17); Console.Write("|   (__)   |");
            Console.SetCursorPosition(28, 18); Console.Write("|   /__\\   |");
            Console.SetCursorPosition(28, 19); Console.Write("|  / @@ \\  |");
            Console.SetCursorPosition(28, 20); Console.Write("|  \\____/  |");
            Console.SetCursorPosition(28, 21); Console.Write("\\__________/");
            Console.SetCursorPosition(31, 22); Console.Write("[CURA]");
        }

        public static void MagoCombate(ref int inimigohp, ref int hp, ref int hpmax)
        {
            Program Var_DP = new Program();
            hpmax = Var_DP.Vida;
            string finalizador;
            int acao, dano = Var_DP.Dano, pocoes = Var_DP.Pocao;
            inimigohp = 12;
            hp = hpmax;
            Random danoprob = new Random();
            ConsoleKeyInfo Tecla;
            do
            {
            sistema:
                Console.Clear();
                Inimigos.Mago();
                Combate.Escolhas();
                finalizador = "1";
                Console.SetCursorPosition(2, 2); Console.Write("Você [{0}] - Inimigo [{1}]", hp, inimigohp);
                Console.SetCursorPosition(2, 3); Console.Write("[ ]");
                Console.SetCursorPosition(3, 3);
                Tecla = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                //Ataque
                if (Tecla.Key == ConsoleKey.Z)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você desfere um golpe no inimigo!");
                    inimigohp = inimigohp - dano;
                    Thread.Sleep(1500);
                }
                if (inimigohp <= 0)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Após uma árdua batalha... Você...");
                    Thread.Sleep(750);
                    Console.SetCursorPosition(2, 5); Console.Write("Consegue derrotar o inimigo!");
                    Thread.Sleep(2250);
                    break;
                }
                if ((Tecla.Key == ConsoleKey.C) && (hp == hpmax))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Sua vida está cheia!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção se você não tiver nenhuma.
                if ((Tecla.Key == ConsoleKey.C) && (pocoes == 0))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você não possui poções...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção.
                if ((Tecla.Key == ConsoleKey.C) && (pocoes > 0))
                {
                    pocoes = pocoes - 1;
                    hp = hp + 5;
                    if (hp > hpmax)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Você recuperou {0} de HP", hpmax - hp);
                        hp = hpmax;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Você bebe uma poção e recupera 5 de HP");
                        Thread.Sleep(1500);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                if ((Tecla.Key != ConsoleKey.C) && (Tecla.Key != ConsoleKey.Z) && (Tecla.Key != ConsoleKey.X))
                {
                    Console.Clear();
                    goto sistema;
                }
                Console.SetCursorPosition(2, 5); Console.Write("Ele te ataca!");
                //Bloqueio
                if (Tecla.Key == ConsoleKey.X)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você se prepara para defender!");
                    Thread.Sleep(1500);
                    continue;
                }
                //Oque rola quando bebe uma pot ou ataca.
                    acao = Convert.ToInt32(danoprob.Next(5, 8));
                    hp = hp - acao;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(2, 6); Console.Write("-{0} de HP", acao);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1500);
                //Determinantes que finalizam a batalha.
                if (hp <= 0)
                {
                    hp = 0;
                    finalizador = "0";
                }
                if (inimigohp <= 0)
                {
                    inimigohp = 0;
                    finalizador = "0";
                }
                Console.Clear();
            } while (finalizador != "0");
        }
        public static void ServoCombate(ref int inimigohp, ref int hp, ref int hpmax)
        {
            Program Var_DP = new Program();
            hpmax = Var_DP.Vida;
            string finalizador;
            int acao, dano = Var_DP.Dano, pocoes = Var_DP.Pocao;
            inimigohp = 15;
            hp = hpmax;
            Random danoprob = new Random();
            ConsoleKeyInfo Tecla;
            do
            {
            sistema:
                Console.Clear();
                Inimigos.Servo();
                Combate.Escolhas();
                finalizador = "1";
                Console.SetCursorPosition(2, 2); Console.Write("Você [{0}] - Inimigo [{1}]", hp, inimigohp);
                Console.SetCursorPosition(2, 3); Console.Write("[ ]");
                Console.SetCursorPosition(3, 3);
                Tecla = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                if (Tecla.Key == ConsoleKey.Z)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você desfere um golpe no inimigo!");
                    inimigohp = inimigohp - dano;
                    Thread.Sleep(1500);
                }
                if (inimigohp <= 0)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Após uma árdua batalha... Você...");
                    Thread.Sleep(750);
                    Console.SetCursorPosition(2, 5); Console.Write("Consegue derrotar o inimigo!");
                    Thread.Sleep(2250);
                    break;
                }
                if ((Tecla.Key == ConsoleKey.C) && (hp == hpmax))
                {

                    Console.SetCursorPosition(2, 4); Console.Write("Sua vida está cheia!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção se você não tiver nenhuma.
                if ((Tecla.Key == ConsoleKey.C) && (pocoes == 0))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você não possui poções...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção.
                if ((Tecla.Key == ConsoleKey.C) && (pocoes > 0))
                {
                    pocoes = pocoes - 1;
                    hp = hp + 5;
                    if (hp > hpmax)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Você recuperou {0} de HP", hpmax - hp);
                        hp = hpmax;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Você bebe uma poção e recupera 5 de HP");
                        Thread.Sleep(1500);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                if ((Tecla.Key != ConsoleKey.C) && (Tecla.Key != ConsoleKey.Z) && (Tecla.Key != ConsoleKey.X))
                {
                    Console.Clear();
                    goto sistema;
                }
                Console.SetCursorPosition(2, 5); Console.Write("Ele te ataca!");
                //Bloqueio
                if (Tecla.Key == ConsoleKey.X)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você se prepara para defender!");
                    Thread.Sleep(1500);
                    continue;
                }
                //Oque rola quando bebe uma pot ou ataca.
                else
                {
                    acao = Convert.ToInt32(danoprob.Next(3, 8));
                    hp = hp - acao;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(2, 6); Console.WriteLine("-{0} de HP", acao);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1500);
                }
                //Determinantes que finalizam a batalha.
                if (hp <= 0)
                {
                    hp = 0;
                    finalizador = "0";
                }
                if (inimigohp <= 0)
                {
                    inimigohp = 0;
                    finalizador = "0";
                }
                Console.Clear();
            } while (finalizador != "0");
        }
        public static void AranhaCombate(ref int inimigohp, ref int hp, ref int hpmax)
        {
            Program Var_DP = new Program();
            hpmax = Var_DP.Vida;
            string finalizador;
            int acao, dano = Var_DP.Dano, pocoes = Var_DP.Pocao;
            inimigohp = 6;
            hp = hpmax;
            Random danoprob = new Random();
            ConsoleKeyInfo Tecla;
            do
            {
            sistema:
                Console.Clear();
                Inimigos.Aranha();
                Combate.Escolhas();
                finalizador = "1";
                Console.SetCursorPosition(2, 2); Console.Write("Você [{0}] - Inimigo [{1}]", hp, inimigohp);
                Console.SetCursorPosition(2, 3); Console.Write("[ ]");
                Console.SetCursorPosition(3, 3);
                Tecla = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                //Ataque
                if (Tecla.Key == ConsoleKey.Z)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você desfere um golpe no inimigo!");
                    inimigohp = inimigohp - dano;
                    Thread.Sleep(1500);
                }
                if (inimigohp <= 0)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Após uma árdua batalha... Você...");
                    Thread.Sleep(750);
                    Console.SetCursorPosition(2, 5); Console.Write("Consegue derrotar o inimigo!");
                    Thread.Sleep(2250);
                    break;
                }
                //Poção se você não tiver nenhuma.
                if ((Tecla.Key == ConsoleKey.C) && (hp == hpmax))
                {

                    Console.SetCursorPosition(2, 4); Console.Write("Sua vida está cheia!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção se você não tiver nenhuma.
                if ((Tecla.Key == ConsoleKey.C) && (pocoes == 0))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você não possui poções...");
                    Thread.Sleep(500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção.
                if ((Tecla.Key == ConsoleKey.C) && (pocoes > 0))
                {
                    pocoes = pocoes - 1;
                    hp = hp + 5;
                    if (hp > hpmax)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Você recuperou {0} de HP", hpmax - hp);
                        hp = hpmax;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Sua poção recupera 5 de HP");
                        Thread.Sleep(1500);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }
                if ((Tecla.Key != ConsoleKey.C) && (Tecla.Key != ConsoleKey.Z) && (Tecla.Key != ConsoleKey.X))
                {
                    Console.Clear();
                    goto sistema;
                }
                Console.SetCursorPosition(2, 5); Console.Write("Ela te ataca!");
                //Bloqueio
                if (Tecla.Key == ConsoleKey.X)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você se prepara para defender");
                    Thread.Sleep(1500);
                    continue;
                }
                //Oque rola quando bebe uma pot ou ataca.
                else
                {
                    acao = Convert.ToInt32(danoprob.Next(2, 5));
                    hp = hp - acao;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(2, 6); Console.WriteLine("-{0} de HP", acao);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1500);
                }
                //Determinantes que finalizam a batalha.
                if (hp <= 0)
                {
                    hp = 0;
                    finalizador = "0";
                }
                if (inimigohp <= 0)
                {
                    inimigohp = 0;
                    finalizador = "0";
                }
                Console.Clear();
            } while (finalizador != "0");

        }

        public static void ValosCombate(ref int inimigohp, ref int hp, ref int hpmax)
        {
            Program Var_DP = new Program();
            hpmax = Var_DP.Vida;
            string finalizador;
            int habilidade, habrecarga = 0, acao, dano = Var_DP.Dano, pocoes = Var_DP.Pocao;
            inimigohp = 15;
            hp = hpmax;
            Random danoprob = new Random();
            Random habilidadeprob = new Random();
            ConsoleKeyInfo Tecla;
            do
            {
            sistema:
                Console.Clear();
                Chefes.ChefeB();
                Combate.Escolhas();
                finalizador = "1";
                Console.SetCursorPosition(2, 2); Console.Write("Você [{0}] - Inimigo [{1}]", hp, inimigohp);
                Console.SetCursorPosition(2, 3); Console.Write("[ ]");
                Console.SetCursorPosition(3, 3);
                Tecla = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                //Ataque
                if (Tecla.Key == ConsoleKey.Z)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você desfere um golpe no inimigo!");
                    inimigohp = inimigohp - dano;
                    Thread.Sleep(1500);
                }
                if (inimigohp <= 0)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Após uma árdua batalha... Você...");
                    Thread.Sleep(750);
                    Console.SetCursorPosition(2, 5); Console.Write("Consegue derrotar o inimigo!");
                    Thread.Sleep(2250);
                    break;
                }
                if ((Tecla.Key == ConsoleKey.C) && (hp == hpmax))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Sua vida está cheia!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção se você não tiver nenhuma.
                if ((Tecla.Key == ConsoleKey.C) && (pocoes == 0))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você não possui poções...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                if(habrecarga > 0)
                {
                    habrecarga = habrecarga - 1 ;
                }
                //Poção.
                if ((Tecla.Key == ConsoleKey.C) && (pocoes > 0))
                {
                    pocoes = pocoes - 1;
                    hp = hp + 5;
                    if (hp > hpmax)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Você recuperou {0} de HP", hpmax - hp);
                        hp = hpmax;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Sua poção recupera 5 de HP");
                        Thread.Sleep(1500);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                if ((Tecla.Key != ConsoleKey.C) && (Tecla.Key != ConsoleKey.Z) && (Tecla.Key != ConsoleKey.X))
                {
                    Console.Clear();
                    goto sistema;
                }
                Console.SetCursorPosition(2, 5); Console.Write("Ele te ataca!");
                //Bloqueio
                if (Tecla.Key == ConsoleKey.X)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você se prepara para defender!");
                    Thread.Sleep(1500);
                    continue;
                }
                //Oque rola quando bebe uma pot ou ataca.
                habilidade = Convert.ToInt32(danoprob.Next(1, 5));
                if ((inimigohp <=20) && (habilidade == 4) && (habrecarga == 0))
                {
                    Console.SetCursorPosition(2, 5); Console.Write("Valos usou Água da vida.");
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(2, 6); Console.Write("Valos recuperou 5 de vida!.");
                    habrecarga = 4;
                    Thread.Sleep(1500);
                    inimigohp = inimigohp + 5;
                }
                else
                {
                    acao = Convert.ToInt32(danoprob.Next(8, 10));
                    hp = hp - acao;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(2, 6); Console.Write("-{0} de HP", acao);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1500);
                }
                //Determinantes que finalizam a batalha.
                if (hp <= 0)
                {
                    hp = 0;
                    finalizador = "0";
                }
                if (inimigohp <= 0)
                {
                    inimigohp = 0;
                    finalizador = "0";
                }
                Console.Clear();
            } while (finalizador != "0");
        }
        public static void MalosCombate(ref int inimigohp, ref int hp, ref int hpmax)
        {
            Program Var_DP = new Program();
            hpmax = Var_DP.Vida;
            string finalizador;
            int habilidade, habrecarga = 0, acao, dano = Var_DP.Dano, pocoes = Var_DP.Pocao, inimigodano = 5;
            inimigohp = 30;
            hp = hpmax;
            Random danoprob = new Random();
            Random habilidadeprob = new Random();
            ConsoleKeyInfo Tecla;
            do
            {
            sistema:
                Console.Clear();
                Chefes.ChefeC();
                Combate.Escolhas();
                finalizador = "1";
                Console.SetCursorPosition(2, 2); Console.Write("Você [{0}] - Inimigo [{1}]", hp, inimigohp);
                Console.SetCursorPosition(2, 3); Console.Write("[ ]");
                Console.SetCursorPosition(3, 3);
                Tecla = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                //Ataque
                if (Tecla.Key == ConsoleKey.Z)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você desfere um golpe no inimigo!");
                    inimigohp = inimigohp - dano;
                    Thread.Sleep(1500);
                }
                if (inimigohp <= 0)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Após uma árdua batalha... Você...");
                    Thread.Sleep(750);
                    Console.SetCursorPosition(2, 5); Console.Write("Consegue derrotar o inimigo!");
                    Thread.Sleep(2250);
                    break;
                }
                if ((Tecla.Key == ConsoleKey.C) && (hp == hpmax))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Sua vida está cheia!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção se você não tiver nenhuma.
                if ((Tecla.Key == ConsoleKey.C) && (pocoes == 0))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você não possui poções...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                if (habrecarga > 0)
                {
                    habrecarga = habrecarga - 1;
                    if (habrecarga == 3)
                    {
                        inimigodano = 5;
                    }
                }
                //Poção.
                if ((Tecla.Key == ConsoleKey.C) && (pocoes > 0))
                {
                    pocoes = pocoes - 1;
                    hp = hp + 5;
                    if (hp > hpmax)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Você recuperou {0} de HP", hpmax - hp);
                        hp = hpmax;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Sua poção recupera 5 de HP");
                        Thread.Sleep(1500);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                if ((Tecla.Key != ConsoleKey.C) && (Tecla.Key != ConsoleKey.Z) && (Tecla.Key != ConsoleKey.X))
                {
                    Console.Clear();
                    goto sistema;
                }
                Console.SetCursorPosition(2, 5); Console.Write("Ele te ataca!");
                //Bloqueio
                if (Tecla.Key == ConsoleKey.X)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você se prepara para defender!");
                    Thread.Sleep(1500);
                    continue;
                }
                habilidade = Convert.ToInt32(habilidadeprob.Next(1, 5));
                if ((habilidade == 4) && (habrecarga == 0))
                {
                    Console.SetCursorPosition(2, 5); Console.Write("Malos fica furioso!");
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(2, 6); Console.Write("O dano de Malos aumenta em + 5.");
                    habrecarga = 7;
                    Thread.Sleep(1500);
                    inimigodano = inimigodano + 5;
                }
                else
                {
                    //Oque rola quando bebe uma pot ou ataca.
                    acao = inimigodano;
                    hp = hp - acao;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(2, 6); Console.Write("-{0} de HP", acao);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1500);
                }
                //Determinantes que finalizam a batalha.
                if (hp <= 0)
                {
                    hp = 0;
                    finalizador = "0";
                }
                if (inimigohp <= 0)
                {
                    inimigohp = 0;
                    finalizador = "0";
                }
                Console.Clear();
            } while (finalizador != "0");
        }
        public static void ArgosCombate(ref int inimigohp, ref int hp, ref int hpmax)
        {
            Program Var_DP = new Program();
            hpmax = Var_DP.Vida;
            string finalizador;
            int habilidade, habrecarga = 0, acao, dano = Var_DP.Dano, pocoes = Var_DP.Pocao;
            inimigohp = 25;
            hp = hpmax;
            Random danoprob = new Random();
            Random habilidadeprob = new Random();
            ConsoleKeyInfo Tecla;
            do
            {
            sistema:
                Console.Clear();
                Chefes.ChefeA();
                Combate.Escolhas();
                finalizador = "1";
                Console.SetCursorPosition(2, 2); Console.Write("Você [{0}] - Inimigo [{1}]", hp, inimigohp);
                Console.SetCursorPosition(2, 3); Console.Write("[ ]");
                Console.SetCursorPosition(3, 3);
                Tecla = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                //Ataque
                if (Tecla.Key == ConsoleKey.Z)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você desfere um golpe no inimigo!");
                    inimigohp = inimigohp - dano;
                    Thread.Sleep(1500);
                }
                if (inimigohp <= 0)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Após uma árdua batalha... Você...");
                    Thread.Sleep(750);
                    Console.SetCursorPosition(2, 5); Console.Write("Consegue derrotar o inimigo!");
                    Thread.Sleep(2250);
                    break;
                }
                if ((Tecla.Key == ConsoleKey.C) && (hp == hpmax))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Sua vida está cheia!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção se você não tiver nenhuma.
                if (habrecarga > 0)
                {
                    habrecarga = habrecarga - 1;
                    if (habrecarga == 2)
                    {
                        dano = dano * 2;
                    }
                }
                if ((Tecla.Key == ConsoleKey.C) && (pocoes == 0))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você não possui poções...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção.
                if ((Tecla.Key == ConsoleKey.C) && (pocoes > 0))
                {
                    pocoes = pocoes - 1;
                    hp = hp + 5;
                    if (hp > hpmax)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Você recuperou {0} de HP", hpmax - hp);
                        hp = hpmax;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Sua poção recupera 5 de HP");
                        Thread.Sleep(1500);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                if ((Tecla.Key != ConsoleKey.C) && (Tecla.Key != ConsoleKey.Z) && (Tecla.Key != ConsoleKey.X))
                {
                    Console.Clear();
                    goto sistema;
                }
                Console.SetCursorPosition(2, 5); Console.Write("Ele te ataca!");
                //Bloqueio
                if (Tecla.Key == ConsoleKey.X)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você se prepara para defender!");
                    Thread.Sleep(1500);
                    continue;
                }
                habilidade = Convert.ToInt32(habilidadeprob.Next(1, 5));
                if ((habilidade == 4) && (habrecarga == 0))
                {
                    Console.SetCursorPosition(2, 5); Console.Write("Argos reune a ajuda dos eventos.");
                    Thread.Sleep(1500);
                    Console.SetCursorPosition(2, 6); Console.Write("Argos aumenta sua defesa!");
                    habrecarga = 5;
                    Thread.Sleep(1500);
                    dano = dano / 2;
                }
                //Oque rola quando bebe uma pot ou ataca.
                acao = Convert.ToInt32(danoprob.Next(5, 8));
                    hp = hp - acao;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(2, 8); Console.Write("-{0} de HP", acao);
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(1500);
                //Determinantes que finalizam a batalha.
                if (hp <= 0)
                {
                    hp = 0;
                    finalizador = "0";
                }
                if (inimigohp <= 0)
                {
                    inimigohp = 0;
                    finalizador = "0";
                }
                Console.Clear();
            } while (finalizador != "0");
        }

        public static void HyndraCombate(ref int inimigohp, ref int hp, ref int hpmax)
        {
            Program Var_DP = new Program();
            hpmax = Var_DP.Vida;
            string finalizador;
            int habilidade, habrecarga = 0, acao, dano = Var_DP.Dano, pocoes = Var_DP.Pocao;
            bool efeito = false;
            inimigohp = 70;
            hp = hpmax;
            Random danoprob = new Random();
            Random habilidadeprob = new Random();
            ConsoleKeyInfo Tecla;
            do
            {
            sistema:
                Console.Clear();
                Chefes.ChefeFinal1();
                Combate.Escolhas();
                finalizador = "1";
                if (efeito == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(2, 1); Console.Write("STATUS: PARALISADO");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.SetCursorPosition(2, 2); Console.Write("Você [{0}] - Inimigo [{1}]", hp, inimigohp);
                Console.SetCursorPosition(2, 3); Console.Write("[ ]");
                Console.SetCursorPosition(3, 3);
                Tecla = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                //Ataque
                if (Tecla.Key == ConsoleKey.Z)
                {
                        Console.SetCursorPosition(2, 4); Console.Write("Você desfere um golpe no inimigo!");
                    if (efeito == true)
                    {
                        Console.SetCursorPosition(2, 5); Console.Write("Você tenta fazer algo mas..");
                        Console.SetCursorPosition(2, 6); Console.Write("Você está paralisado.");
                        goto Golpe;
                    }
                    inimigohp = inimigohp - dano;
                    Thread.Sleep(1500);
                }
                if (inimigohp <= 0)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Após uma árdua batalha... Você...");
                    Thread.Sleep(750);
                    Console.SetCursorPosition(2, 5); Console.Write("Hyndra começa a reerguer...");
                    Thread.Sleep(750);
                    Console.SetCursorPosition(2, 6); Console.Write("Ele já não é mais o mesmo.");
                    Combate.HyndraCombate2(ref inimigohp, ref hp, ref hpmax);                   
                    Thread.Sleep(2250);
                    break;
                }
                if ((Tecla.Key == ConsoleKey.C) && (hp == hpmax))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Sua vida está cheia!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção se você não tiver nenhuma.
                if (habrecarga > 0)
                {
                    habrecarga = habrecarga - 1;
                    if (habrecarga < 4)
                    {
                        efeito = false;
                    }
                }
                if ((Tecla.Key == ConsoleKey.C) && (pocoes == 0))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você não possui poções...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção.
                if ((Tecla.Key == ConsoleKey.C) && (pocoes > 0))
                {
                    pocoes = pocoes - 1;
                    hp = hp + 5;
                    if (hp > hpmax)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Você recuperou {0} de HP", hpmax - hp);
                        hp = hpmax;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Sua poção recupera 5 de HP");
                        Thread.Sleep(1500);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                if ((Tecla.Key != ConsoleKey.C) && (Tecla.Key != ConsoleKey.Z) && (Tecla.Key != ConsoleKey.X))
                {
                    Console.Clear();
                    goto sistema;
                }
                Console.SetCursorPosition(2, 5); Console.Write("Ele te ataca!");
                //Bloqueio
                if (Tecla.Key == ConsoleKey.X)
                {
                    if (efeito == true)
                    {
                        Console.SetCursorPosition(2, 5); Console.Write("Você tenta fazer algo mas..");
                        Console.SetCursorPosition(2, 6); Console.Write("Você está paralisado.");
                        goto Golpe;
                    }
                    Console.SetCursorPosition(2, 4); Console.Write("Você se prepara para defender!");
                    Thread.Sleep(1500);
                    continue;
                }
                habilidade = Convert.ToInt32(habilidadeprob.Next(1, 5));
                if ((habilidade == 4) && (habrecarga == 0))
                {
                    Console.SetCursorPosition(2, 5); Console.Write("Hyndra emana uma força estática");
                    Thread.Sleep(2000);
                    Console.SetCursorPosition(2, 6); Console.Write("Hyndra lhe paralisa!");
                    habrecarga = 3;
                    efeito = true;
                    Thread.Sleep(1500);
                }
            Golpe:
                //Oque rola quando bebe uma pot ou ataca.
                acao = Convert.ToInt32(danoprob.Next(8, 14));
                hp = hp - acao;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(2, 7); Console.Write("-{0} de HP", acao);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1500);
                //Determinantes que finalizam a batalha.
                if (hp <= 0)
                {
                    hp = 0;
                    finalizador = "0";
                }
                if (inimigohp <= 0)
                {
                    inimigohp = 0;
                    finalizador = "0";
                }
                Console.Clear();
            } while (finalizador != "0");
        }
        public static void HyndraCombate2(ref int inimigohp, ref int hp, ref int hpmax)
        {
            Program Var_DP = new Program();
            hpmax = Var_DP.Vida;
            string finalizador;
            int habilidade = 0, habrecarga = 0, habrecargajogador = 0, acao, dano = Var_DP.Dano, pocoes = Var_DP.Pocao;
            bool efeito = false, malos = false, argos = false, valos = false;
            inimigohp = 110;
            hp = hpmax;
            Random danoprob = new Random();
            Random habilidadeprob = new Random();
            Random inimigodano = new Random();
            ConsoleKeyInfo Tecla;
            do
            {
            sistema:
                Console.Clear();
                Chefes.ChefeFinal2();
                Combate.Escolhas();
                acao = Convert.ToInt32(inimigodano.Next(8, 14));
                finalizador = "1";
                if (efeito == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.SetCursorPosition(2, 1); Console.Write("STATUS: PARALISADO");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.SetCursorPosition(2, 2); Console.Write("Você [{0}] - Inimigo [{1}]", hp, inimigohp);
                Console.SetCursorPosition(2, 3); Console.Write("[ ]");
                Console.SetCursorPosition(3, 3);
                Tecla = Console.ReadKey();
                Console.ForegroundColor = ConsoleColor.White;
                //Ataque
                if ((valos == true) && (habrecargajogador == 0))
                {
                    valos = false;
                    habilidade = 0;
                }
                if ((malos == true) && (habrecargajogador == 0))
                {
                    malos = false;
                    habilidade = 0;
                }
                if ((argos == true) && (habrecargajogador == 0))
                {
                    argos = false;
                    habilidade = 0;
                }
                if ((malos == true) && (habrecargajogador > 0))
                {
                    habrecargajogador = habrecargajogador - 1;
                    if (habrecargajogador == 3)
                    {
                        dano = dano - 5;
                    }
                }
                if ((valos == true) && (habrecargajogador > 0))
                {
                    habrecargajogador = habrecargajogador - 1;
                }
                if ((argos == true) && (habrecargajogador > 0))
                {
                    habrecargajogador = habrecargajogador - 1;
                    if (habrecargajogador == 3)
                    {
                        acao = acao * 2;
                    }
                }
                if (habilidade == 0)
                {
                    habilidade = Convert.ToInt32(habilidadeprob.Next(1, 5));
                    if ((hp <= hpmax - 5) && (habilidade == 2))
                    {
                        //Valos
                        Console.SetCursorPosition(3, 9); Console.Write("As águas de Valos lhe curam!");
                        valos = true;
                        habrecargajogador = 4;
                    }
                    else if (habilidade == 3)
                    {
                        //Malos
                        Console.SetCursorPosition(3, 9); Console.Write("A fúria de Malos lhe da forças!");
                        dano = dano + 5;
                        malos = true; ;
                        habrecargajogador = 7;
                    }
                    else if (habilidade == 4)
                    {
                        //Argos
                        Console.SetCursorPosition(3, 9); Console.Write("Os ventos de Argos lhe protege!");
                        argos = true;
                        acao = acao / 2;
                        habrecargajogador = 5;
                    }
                }
                if (Tecla.Key == ConsoleKey.Z)
                {
                        Console.SetCursorPosition(2, 4); Console.Write("Você desfere um golpe no inimigo!");
                    if (efeito == true)
                    {
                        Console.SetCursorPosition(2, 5); Console.Write("Você tenta fazer algo mas..");
                        Console.SetCursorPosition(2, 6); Console.Write("Você está paralisado.");
                        goto Golpe;
                    }
                    inimigohp = inimigohp - dano;
                    Thread.Sleep(1500);
                }
                if (inimigohp <= 0)
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Após uma árdua batalha... Você...");
                    Thread.Sleep(750);
                    Console.SetCursorPosition(2, 5); Console.Write("Consegue derrotar Hyndra!");
                    Thread.Sleep(2250);
                    break;
                }
                if ((Tecla.Key == ConsoleKey.C) && (hp == hpmax))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Sua vida está cheia!");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção se você não tiver nenhuma.
                if (habrecarga > 0)
                {
                    habrecarga = habrecarga - 1;
                    if (habrecarga < 4)
                    {
                        efeito = false;
                    }
                }
                if ((Tecla.Key == ConsoleKey.C) && (pocoes == 0))
                {
                    Console.SetCursorPosition(2, 4); Console.Write("Você não possui poções...");
                    Thread.Sleep(1500);
                    Console.Clear();
                    goto sistema;
                }
                //Poção.
                if ((Tecla.Key == ConsoleKey.C) && (pocoes > 0))
                {
                    pocoes = pocoes - 1;
                    hp = hp + 5;
                    if (hp > hpmax)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Você recuperou {0} de HP", hpmax - hp);
                        hp = 20;
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.SetCursorPosition(2, 4); Console.Write("Sua poção recupera 5 de HP");
                        Thread.Sleep(1500);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                }

                if ((Tecla.Key != ConsoleKey.C) && (Tecla.Key != ConsoleKey.Z) && (Tecla.Key != ConsoleKey.X))
                {
                    Console.Clear();
                    goto sistema;
                }
                Console.SetCursorPosition(2, 5); Console.Write("Ele te ataca!");
                //Bloqueio
                if (Tecla.Key == ConsoleKey.X)
                {
                    if (efeito == true)
                    {
                        Console.SetCursorPosition(2, 5); Console.Write("Ao menos essa era a intensão..");
                        Console.SetCursorPosition(2, 6); Console.Write("Você está paralisado.");
                        goto Golpe;
                    }
                    Console.SetCursorPosition(2, 4); Console.Write("Você se prepara para defender!");
                    Thread.Sleep(1500);
                    continue;
                }
                habilidade = Convert.ToInt32(habilidadeprob.Next(1, 5)); ;
                if ((habilidade == 4) && (habrecarga == 0))
                {
                    Console.SetCursorPosition(2, 5); Console.Write("Hyndra emana uma força estática");
                    Thread.Sleep(2000);
                    Console.SetCursorPosition(2, 6); Console.Write("Hyndra lhe paralisa!");
                    habrecarga = 5;
                    efeito = true;
                    Thread.Sleep(1500);
                }
            Golpe:
                //Oque rola quando bebe uma pot ou ataca.
                hp = hp - acao;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(2, 7); Console.Write("-{0} de HP", acao);
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(1500);
                //Determinantes que finalizam a batalha.
                if (hp <= 0)
                {
                    hp = 0;
                    finalizador = "0";
                }
                if (inimigohp <= 0)
                {
                    inimigohp = 0;
                    finalizador = "0";
                }
                Console.Clear();
            } while (finalizador != "0");
        }
    }
}