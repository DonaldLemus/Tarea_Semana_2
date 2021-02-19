using System;

namespace Descuento_el_20
{
    class Program
    {
        static void Main(string[] args)
        {
            string total;
            double total2;
            double descuento = 0.20;
            double descuento2;
            double totalfinal;

            Console.Write("Ingrese la cantidad a pagar: Q");
            total = Console.ReadLine();
            total2 = Convert.ToDouble(total);

            if (total2 >= 300)
            {
                Console.WriteLine("Aplica para un descuento del 20%");
                Console.ReadKey();
                descuento2 = total2 * descuento;
                totalfinal = total2 - descuento2;
                Console.WriteLine("El total a pagar es: Q" + totalfinal);              
            }
            else
            {
                Console.WriteLine("No aplica para el descuento");
                Console.ReadKey();
                Console.WriteLine("El total es: Q" + total);
                
            }

        }
    }
}
