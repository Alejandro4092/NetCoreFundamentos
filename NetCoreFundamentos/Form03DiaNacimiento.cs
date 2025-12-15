using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form03DiaNacimiento : Form
    {
        public Form03DiaNacimiento()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form03DiaNacimiento_Load(object sender, EventArgs e)
        {

        }

        private void txtDia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMes_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNacimiento_Click(object sender, EventArgs e)
        {
            int dia= int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int anyo = int.Parse(this.txtAño.Text);
            if (mes == 1)
            {
                mes = 13;
                anyo--;

            }
            if (mes == 2)
            {
                mes = 14;
                anyo--;
            }
            int mes2 = ((mes + 1) * 3) / 5;
            int anyo2 = anyo / 4;
            int anyo3 = anyo / 100;
            int anyo4 = anyo / 400;
            int operacion1 = dia + (mes * 2) + anyo + mes2 + anyo2 - anyo3 + anyo4 + 2;
            int resultado = operacion1 / 7;
            int resultadodefinitivo = operacion1 - (resultado * 7);

            switch (resultadodefinitivo)
            {
                case 0:
                    lblDia.Text = "Tu dia es sabado";
                    break;
                case 1:
                    lblDia.Text = "Tu dia es Domingo";
                    break;
                case 2:
                    lblDia.Text = "Tu dia es Lunes";
                    break;
                case 3:
                    lblDia.Text = "Tu dia es Martes";
                    break;
                case 4:
                    lblDia.Text = "Tu dia es Miercoles";
                    break;
                case 5:
                    lblDia.Text = "Tu dia es Jueves";
                    break;
                case 6:
                    lblDia.Text = "Tu dia es Viernes";
                    break;

            }
        }
    }
}
