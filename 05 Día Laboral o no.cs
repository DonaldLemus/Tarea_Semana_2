using System;

namespace Día_Laboral_o_no
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.WriteLine("1 Lunes");
            Console.WriteLine("2 Martes ");
            Console.WriteLine("3 Miercoles ");
            Console.WriteLine("4 Jueves ");
            Console.WriteLine("5 Viernes ");
            Console.WriteLine("6 Sábado ");
            Console.WriteLine("7 Domingo ");
            Console.Write("Elija un día de la semana ingresando el número: ");
            dia = Convert.ToInt32(Console.ReadLine());

            switch(dia)
            {
                case 1: Console.WriteLine("Es un día laboral"); break;

                case 2: Console.WriteLine("Es un día laboral"); break;

                case 3: Console.WriteLine("Es un día laboral"); break;

                case 4: Console.WriteLine("Es un día laboral"); break;

                case 5: Console.WriteLine("Es un día laboral"); break;

                case 6: Console.WriteLine("No es un día laboral"); break;

                case 7: Console.WriteLine("No es un día laboral"); break;

                default: Console.WriteLine("No ha seleccionada ninguna opción"); break;

            }
            Console.ReadKey();
        }
    }
}
