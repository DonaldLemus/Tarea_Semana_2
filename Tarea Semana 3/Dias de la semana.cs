using System;

namespace Dias_de_la_semana
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;

            Console.Write("Elija un número del 1 al 7: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch(opcion)
            {
                case 1: 
                    Console.WriteLine("El día correspondiente al numero 1 es Lunes");
                break;

                case 2:
                    Console.WriteLine("El día correspondiente al numero 2 es Martes");
                break;

                case 3:
                    Console.WriteLine("El día correspondiente al numero 3 es Miercoles");
                break;

                case 4:
                    Console.WriteLine("El día correspondiente al numero 4 es Jueves");
                break;

                case 5:
                    Console.WriteLine("El día correspondiente al numero 5 es Viernes");
                break;

                case 6:
                    Console.WriteLine("El día correspondiente al numero 6 es Sábado");
                break;

                case 7:
                    Console.WriteLine("El día correspondiente al numero 7 es Domingo");
                break;

                default:
                    Console.WriteLine("El número que ingresaste no está dentro del rango especificado");
                break;
            }
        }
    }
}
