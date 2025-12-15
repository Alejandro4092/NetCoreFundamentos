using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string textoNumeros = this.txtNumero.Text;
            int suma = 0;
            //Recorremos todo el contenido de Textonumeros
            for(int i = 0; i < textoNumeros.Length; i++)
            {
               //recuperar cada caracter del texto
                char caracter = textoNumeros[i];
                //convertir en numero cada caracter
                //esta conversion recupera el asci que no nos vale
                //necesitamos el literal del numero 1

                //int numero = int.Parse(caracter.ToString());
                int numero = Convert.ToInt32(caracter.ToString());
                suma += numero;
            }
            this.lblResultado.Text = "La suma de " + textoNumeros + " es " + suma;

        }
    }
}
