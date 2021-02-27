 using System;

namespace Radianes_a_grados
{
    class Program
    {
        static void Main(string[] args)
        {
            int opción;
            double numero, resultado, pi = 3.14;
            try
            {
                Console.WriteLine("1 Convertir de Radianes a Grados");
                Console.WriteLine("2 Convertir de Grados a Radiades");
                Console.Write("Ingrese que operación quiere realizar: ");
                opción = Convert.ToInt32(Console.ReadLine()); 

                switch(opción)
                {
                    case 1:
                        Console.WriteLine("Convertir de Radianes a Grados");
                    Console.Write("Ingrese la cifra que quiere convertir: ");
                    numero = Convert.ToDouble(Console.ReadLine());

                    resultado = (numero * 180) / pi;

                    Console.WriteLine("La cantidad en grados es: " + resultado);
                    Console.ReadKey();
                    break;

                    case 2:
                        Console.WriteLine("Convertir de Grados a Radianes");
                    Console.Write("Ingrese la cifra que quiere convertir: ");
                    numero = Convert.ToDouble(Console.ReadLine());

                    resultado = (numero / 180) * pi;
                    Console.WriteLine("La cantidad en radianes es: " + resultado);
                    Console.ReadKey();
                    break;
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Ingresaste datos invalidos");
                Console.ReadLine();
            }
            
        }
    }
}
