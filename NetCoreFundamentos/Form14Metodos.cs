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
    public partial class Form14Metodos : Form
    {
        public Form14Metodos()
        {
            InitializeComponent();
        }
        //recibimos un wrapper por valor
        int GetDobleValor(int numero)
        {
            return numero * 2;
        }
        void CambiarColor(Button boton)
        {
            boton.BackColor = Color.LightGoldenrodYellow;
        }
        void GetDobleReferencia(ref int numero)
        {
            numero = numero * 2;
        }

        private void btnDobleValor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            int resultado = this.GetDobleValor(num);
            this.lblResultado.Text = resultado.ToString();
        }

        private void btnObjetoReferencia_Click(object sender, EventArgs e)
        {
            this.CambiarColor(this.btnDobleReferencia);
            this.CambiarColor(this.btnDobleValor);
        }

        private void btnDobleReferencia_Click(object sender, EventArgs e)
        {
            int num = int.Parse(this.txtNumero.Text);
            this.GetDobleReferencia(ref num);
            this.lblResultado.Text = num.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
