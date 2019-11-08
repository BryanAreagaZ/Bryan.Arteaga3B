using System;
using System.Collections.Generic;
using System.Text;

namespace TadPila_TadCola.CS
{
    class Nodo
    {
        private int dato;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        private Nodo siguiente = null;
        internal Nodo Siguiente { get => siguiente; set => siguiente = value; }

        public override string ToString()
        {
            return string.Format("{[0]}", dato);
        }


    }
}
