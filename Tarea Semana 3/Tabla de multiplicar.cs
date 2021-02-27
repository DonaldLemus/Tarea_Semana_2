using System;

namespace Tabla_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado, numero2 = 1;

            Console.Write("Ingrese cualquier numero para ver su tabla de multiplicar del 1 al 10: ");
            numero = Convert.ToInt16(Console.ReadLine());

            for(int i = 0; i < 10; i++)
            {
                resultado = numero * numero2;

                Console.WriteLine("{0} * {1} = {2}", numero, numero2, resultado);
                
                numero2++;
            }
            Console.ReadKey();
        }
    }
}
