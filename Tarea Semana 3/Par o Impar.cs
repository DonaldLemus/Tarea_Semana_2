using System;

namespace Par_o_Impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Ingrese un número para comprobar si es par o impar: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.Write("El numero {0} es par", numero);
                Console.ReadKey();
            }
            else
            {
                Console.Write("El numero {0} es impar", numero);
                Console.ReadKey();
            }
        }
    }
}
