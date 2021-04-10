using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoPromedios
{
    public partial class Form1 : Form
    {
        private string[] arregloNotas;
        ClsArchivo clsArchivo = new ClsArchivo();
        ClsArreglos clsArreglos = new ClsArreglos();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFileDialog = new OpenFileDialog();
            
            openFileDialog.Filter = "(*.csv)|*.csv";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var archivo = openFileDialog.FileName;
                textBox1.Text = archivo;
                String resultado = clsArchivo.LeerTodoArchivo(archivo);
                //arregloNotas = clsArchivo.LeerArchivo(archivo);
                txtDatos.Text = resultado;
                string[] resultadoArray = clsArchivo.LeerArchivo(archivo);
                //ordeno por nombre
                string[] arrayOrdenadoNombre = clsArreglos.OrdenarString(resultadoArray);
                foreach (var item in arrayOrdenadoNombre)
                {
                    listBox1.Items.Add(item);
                }
                //saco promedio
                string[] promedios = clsArreglos.OrdenaPromedio(resultadoArray);

                foreach (var item in promedios)
                {
                    listBox2.Items.Add(item);
                }
                //extraigo el menor promedio del array
                string[] dato = promedios[promedios.Length - 1].Split(';');
                TxtMenorNota.Text = dato[0];
                txtPromedioMenor.Text = dato[1];
                //extraigo el mayor promedio del array
                dato = promedios[0].Split(';');
                txtMayorNota.Text = dato[0];
                TxtPromedioMayor.Text = dato[1];



            }

            
        }




    }
}

 