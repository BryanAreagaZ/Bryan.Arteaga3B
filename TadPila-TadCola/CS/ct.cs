using System;
using System.Collections.Generic;
using System.Text;

namespace TadPila_TadCola.CS
{
    class ct
    {
        private Nodo ancla;

        private Nodo trabajo;

        public ct()
        {
            ancla = new Nodo();

            ancla.Siguiente = null;

        }

        public void Push(int pDato)
        {
            Nodo temp = new Nodo();

            temp.Dato = pDato;

            temp.Siguiente = ancla.Siguiente;

            ancla.Siguiente = temp;


        }

        public int Pop()
        {
            int valor = 0;

            if (ancla.Siguiente != null)
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;

                ancla.Siguiente = trabajo.Siguiente;
                trabajo.Siguiente = null;
            }
            return valor;
        }

        public int Peek()
        {
            int valor = 0;
            if (ancla.Siguiente != null)
            {
                trabajo = ancla.Siguiente;
                valor = trabajo.Dato;


            }
            return valor;
        }

        public void Transversa()
        {
            trabajo = ancla;

            while (trabajo.Siguiente != null)
            {
                trabajo = trabajo.Siguiente;
                int d = trabajo.Dato;
                Console.WriteLine("{[0]}", d);
            }
        }



    }
}