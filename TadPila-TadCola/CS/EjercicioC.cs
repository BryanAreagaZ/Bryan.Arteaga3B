using System;
using System.Collections.Generic;
using System.Text;

namespace TadPila_TadCola.CS
{
    class EjercicioC
    {
        public void ejercicioC()
        {

            COLA cola = new COLA();
            bool bon = true; int valor;
            int i = 0;
            while (bon) {
                i++;
            valor = Menu();
                switch (valor)
                {
                    case 1:
                        cola.InsertarNodo();
                        break;
                    case 2:
                        cola.DesplegarCola();
                        break;
                    case 3:
                        bon = false;
                        break;
                    default:
                        Console.WriteLine("elija una opción correcta");
                        Console.ReadKey();
                        break;
                }
            } 

            int Menu()
            {
                Console.Clear();


                Console.WriteLine("||||||||||||||| MENU |||||||||||||||");
                Console.WriteLine("====================================\n");
                Console.WriteLine(" 1) Ingresar numeros :\n");
                Console.WriteLine(" 2) Recorrer cola:\n");
                Console.WriteLine(" 3) Salir:\n");
                int opcion = int.Parse(Console.ReadLine());
                return opcion;
            }


        }
    }
}

