using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPromedios
{
    class ClsArreglos
    {  
        //constructor
        public ClsArreglos()
        {

        }

        //metodo para ordenar por nombre
       public string[] OrdenarString(string[] array) {
            int tamanioArray = array.Length;
            //creo un array sin titulos
            string[] nombres = new string[tamanioArray - 1];

            for (int i = 0; i < tamanioArray; i++)
            {
                //con este if evito que tome en cuenta la fila de titulo
                if (i > 0)
                {
                    string[] delimitado = array[i].Split(';');
                    nombres[i-1] = (delimitado[1]);
                }

            }           
            //convierto a array y luego lo ordeno con funcion SORT
          
            Array.Sort(nombres, StringComparer.InvariantCulture);
            return nombres;
        }


        //metodo para ordenar por promedio
        public string[] OrdenaPromedio(string[] array)
        {
          
            int tamanioArray = array.Length;
            //creo un array sin titulos
            int[] promedios = new int[tamanioArray - 1];
            string[] nombres = new string[tamanioArray - 1];

            for (int i = 0; i < tamanioArray; i++)
            {
                //con este if evito que tome en cuenta la fila de titulo
                if (i > 0)
                {
                    string[] delimitado = array[i].Split(';');
                    int parcial1 = Int32.Parse(delimitado[2]);
                    int parcial2 = Int32.Parse(delimitado[3]);
                    int parcial3 = Int32.Parse(delimitado[4]);
                    int promedio = ( parcial1 + parcial2 + parcial3 ) / 3;
                    promedios[i-1] = promedio;
                    nombres[i - 1] = delimitado[1];

                }

            }


            return Metodo_Burbuja2(promedios, nombres);
        }




       string[] Metodo_Burbuja2(int[] promedio, string[] nombre)
        {
            //Metodo de la burbuja
            string[] nuevoArray = new string[promedio.Length];
            int i, j;
            int mb;
            string mbNombre;
            for (i = 0; i < promedio.Length; i++)
            {
                for (j = 0; j < promedio.Length - 1; j++)
                {
                    if (promedio[i] > promedio[j])
                    {
                        //promedio
                        mb = promedio[i];
                        promedio[i] = promedio[j];
                        promedio[j] = mb;
                        //nombre
                        mbNombre = nombre[i];
                        nombre[i] = nombre[j];
                        nombre[j] = mbNombre;

                    }
                }
            }
            //ingresa en nuevo array los array ordenados
            for (i = 0; i < promedio.Length; i++)
            {
                nuevoArray[i] = nombre[i] + ";" + promedio[i].ToString();
            }
            return nuevoArray;
        }
    }
}
