using System;
using System.Collections.Generic;
using System.Text;

namespace TadPila_TadCola.CS
{
    class EjercicioP
    {
        public void ejercicioP()
        {
            ct mipila = new ct();
            bool ben = true;
            int i = 0;
            while (ben)
            {
                i++;
                int valor = Menu();
                switch (valor)
                {


                    case 1:

                        Console.WriteLine("|||||||||||||||Ingrese el nuemero|||||||||||||||");
                        mipila.Push(int.Parse(Console.ReadLine()));
                        Console.ReadKey();
                        break;

                    case 2:
                        Console.WriteLine(mipila.Pop());
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine(mipila.Peek());
                        Console.ReadKey();
                        break;
                    case 4:
                        ben = false;
                        break;
                    default:
                        Console.WriteLine("Elija una opción correcta");
                        Console.ReadKey();
                        break;
                }
            }

            int Menu()
            {
                Console.Clear();


                Console.WriteLine("||||||||||||||| MENU |||||||||||||||");
                Console.WriteLine("====================================\n");
                Console.WriteLine(" 1) Apilar:\n");
                Console.WriteLine(" 2) Desapilar:\n");
                Console.WriteLine(" 3) Mirar cima:\n");
                Console.WriteLine(" 4) Salir:\n");
                int opcion = int.Parse(Console.ReadLine());
                return opcion;
            }
        }
    }
}
