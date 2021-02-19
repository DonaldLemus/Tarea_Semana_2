using System;

namespace Calcular_el_salario_semanal
{
    class Program
    {
        static void Main(string[] args)
        {
            int extra, hora, total;
            
            Console.Write("¿Cuántas horas extra trabajó?: ");
            extra = Convert.ToInt32(Console.ReadLine());

            if (extra == 0) 
            {
                Console.Write("Ingrese las horas trabajadas: ");
                hora = Convert.ToInt32(Console.ReadLine());
                total = hora * 16;
                
                Console.WriteLine("Su salario es de: Q"+ total);
                Console.ReadKey();
            }
            else
            {
                total = (extra * 20) + 640;

                Console.Write("Su salario con horas extra es de: Q"+ total);
                Console.ReadKey();
            }


        }
    }
}
