using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TadPila_TadCola.CS;

namespace TadPila_TadCola
{
    class Program
    {
        static void Main(string[] args)
        {
            EjercicioP pila = new EjercicioP();
            EjercicioC cola = new EjercicioC();

            bool ban = true;
            Console.ForegroundColor = ConsoleColor.Red;
            do
            {
                int valor;
                valor = Menu();



                switch (valor)
                {
                    case 1:
                        pila.ejercicioP();
                        break;
                    case 2:
                        cola.ejercicioC();
                        break;
                    case 3:
                        ban = false;
                        break;
                    default:
                        Console.WriteLine("elija una opcion correcta");
                        Console.ReadKey();
                        break;
                }
            } while (ban);

            int Menu()
            {
                Console.Clear();
                int opcion;

                Console.WriteLine("||||||||||||||| MENU |||||||||||||||");
                Console.WriteLine("====================================\n");
                Console.WriteLine(" 1) Ejercicio Pila");
                Console.WriteLine(" 2) Ejercicio Cola");
                Console.WriteLine(" 3) Salir\n");
                opcion = int.Parse(Console.ReadLine());
                return opcion;



            }
        }


    }


}
