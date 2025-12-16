using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form09Isbn : Form
    {
        public Form09Isbn()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string isbn = this.txtIsbn.Text;
            if (isbn.Length != 10)
            {
                MessageBox.Show("El ISBN debe ser de 10 caracteres");
            }
            else
            {
                int suma = 0;
                for (int i = 0; i < isbn.Length; i++)
                {
                    char letra = isbn[i];
                    int numero = int.Parse(letra.ToString());
                    int multi = numero * (i + 1);
                    suma += multi;
                }
                if (suma % 11 == 0)
                {
                    this.lblMensaje.Text = "ISBN correcto";
                }
                else
                {
                    this.lblMensaje.Text = "ISBN no válido";
                }
            }
        }
    }
}
 
