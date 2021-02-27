using System;

namespace Numero_primos_del_1_al_1000
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 2, divisible = 0;
            while (numero <= 1000)
            {
                for(int i = 1; i<= numero; i++)
                {
                    if(numero % i == 0)
                    {
                        divisible++;
                    }
                    if(divisible>2)
                    {
                        break;
                    }    
                }
                if(divisible == 2)
                {
                    Console.WriteLine("{0} es un numero primo", numero);
                }
                divisible = 0;
                numero++;
            }
            Console.ReadKey();
        }
    }
}
