using System;
using System.Collections.Generic;
using System.Text;

namespace TadPila_TadCola.CS
{
    class COLA
    {
        private Nodo primero = new Nodo();
        private Nodo ultimo = new Nodo();

        public COLA()
        {
            primero = null;
        }

        public void InsertarNodo()
        {

            Nodo nuevo = new Nodo();
            Console.WriteLine("||||||||||||||| ingrese un numero |||||||||||||||:\n");
            nuevo.Dato = int.Parse(Console.ReadLine());

            if (primero == null)
            {
                primero = nuevo;
                primero.Siguiente = nuevo;
                ultimo = nuevo;
            }

            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                ultimo = nuevo;
            }



            Console.WriteLine("\n*******Ingresado correctamente**********");


        }
        public void DesplegarCola()
        {
            Nodo actual = new Nodo();
            actual = primero;
            if (primero != null)
            {
                while (actual != null)
                {
                    Console.WriteLine(" " + actual.Dato);
                    actual = actual.Siguiente;
                    Console.ReadKey();
                }
            }
            else
            {
                Console.WriteLine("************La cola esta vacía*************");
                Console.ReadKey();
            }
        }
    }
}
