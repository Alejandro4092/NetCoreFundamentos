using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace NetCoreFundamentos
{
    public partial class Form08StringBuilder : Form
    {
        public Form08StringBuilder()
        {
            InitializeComponent();
        }

        private void btnInvertirString_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtTexto.Text;
            int longitud = cadena.Length;
            //Comenzamos el proceso
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                //siempre recuperamos la ultima letra
                char letra = cadena[longitud - 1];
                //elminamos la utltima letra
                cadena = cadena.Remove(longitud - 1,1);
                //insertamos la letra en la posicion i del bucle
                cadena = cadena.Insert(i, letra.ToString());
            }
            //finalizamos el proces
            krono.Stop();
            //el objeto stopwatch contiene una serie de propiedades 
            //para comprobar el tiempo entre procesos
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds + ", Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena;

        }

        private void btnInvertirStringBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            StringBuilder cadena = new StringBuilder();
            //para añadir contenido tiene un metodo append
            cadena.Append(this.txtTexto.Text);
            int longitud = cadena.Length;
            //Comenzamos el proceso
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                //siempre recuperamos la ultima letra
                char letra = cadena[longitud - 1];
                //elminamos la utltima letra
                cadena = cadena.Remove(longitud - 1,1);
                //insertamos la letra en la posicion i del bucle
                cadena = cadena.Insert(i, letra.ToString());
            }
            //finalizamos el proces
            krono.Stop();
            //el objeto stopwatch contiene una serie de propiedades 
            //para comprobar el tiempo entre procesos
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds + ", Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena.ToString();

        }
    }
}
