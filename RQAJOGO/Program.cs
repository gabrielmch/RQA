using System;

namespace RQAJOGO
{
    class Program
    {
        private static int dano = 5;
        private static int pocao = 2;
        private static int vida = 15;
        public int Dano { get { return dano; } set { dano = value; } }
        public int Pocao { get { return pocao; } set { pocao = value; } }
        public int Vida { get { return vida; } set { vida = value; } }

        private static bool item1 = false;
        private static bool item2 = false;
        private static bool item3 = false;

        public bool PegarItem1 { get { return item1; } set { item1 = value; } }
        public bool PegarItem2 { get { return item2; } set { item2 = value; } }
        public bool PegarItem3 { get { return item3; } set { item3 = value; } }

        public static void Main(string[] args)
        {
            Console.SetWindowSize(76, 24);
            Console.Title = "Ruínas dos Quatro Arcontes";
            Console.CursorVisible = false;

            Abertura.Inicializacao();
            Abertura.MenuLogica();
        }
    }
}
