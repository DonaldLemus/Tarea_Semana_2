using System;

namespace Saber_si_es_un_numero_primo
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero, divisible = 0;

            Console.Write("Ingrese un numero para saber si es primo: ");
            numero = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    divisible++;
                }
                if (divisible > 2)
                {
                    break;
                }
            }
            if(divisible == 2)
            {
                Console.WriteLine("Es un numero primo");
            }
            else
            {
                Console.WriteLine("No es un numero primo");
            }
            Console.ReadKey();
        }
    }
}
