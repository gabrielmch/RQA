using System;
using System.Collections.Generic;
using System.Text;

namespace RQAJOGO
{
    class BatalhaUnica
    {
        private static bool a1 = false;
        private static bool a2 = false;
        private static bool a3 = false;

        private static bool b1 = false;
        private static bool b2 = false;

        private static bool c1 = false;
        private static bool c2 = false;
        private static bool c3 = false;

        private static bool chefea = false;
        private static bool chefeb = false;
        private static bool chefec = false;

        public bool A1 { get { return a1; } set { a1 = value; } }
        public bool A2 { get { return a2; } set { a2 = value; } }
        public bool A3 { get { return a3; } set { a3 = value; } }

        public bool B1 { get { return b1; } set { b1 = value; } }
        public bool B2 { get { return b2; } set { b2 = value; } }

        public bool C1 { get { return c1; } set { c1 = value; } }
        public bool C2 { get { return c2; } set { c2 = value; } }
        public bool C3 { get { return c3; } set { c3 = value; } }

        public bool Chefea { get { return chefea; } set { chefea = value; } }
        public bool Chefeb { get { return chefeb; } set { chefeb = value; } }
        public bool Chefec { get { return chefec; } set { chefec = value; } }
    }
}
