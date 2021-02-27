using System;

namespace Impuesto_de_un_producto
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            double impuesto, valor, final;

            Console.WriteLine("1 Medicina");
            Console.WriteLine("2 Otro");
            Console.Write("Seleccioné que tipo de producto tiene: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1: Console.Write("Ingrese el precio del producto: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ya que su producto es medicina no se aplica el impuesto");
                    Console.Write("El total es: {0}", valor);
                    break;
                case 2: Console.Write("Ingrese el precio del producto: Q");
                    valor = Convert.ToDouble(Console.ReadLine());

                    impuesto = (valor * 12) / 100;

                    final = valor + impuesto;
                    Console.WriteLine("El impuesto es de: {0}",  impuesto);
                    Console.Write("E total final es: {0}", final);
                    break;
            }

        }
    }
}
