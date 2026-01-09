using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckbox : Form
    {
        List<CheckBox> checkboxes;
        public Form18SumarCheckbox()
        {
            InitializeComponent();
            this.checkboxes = new List<CheckBox>();
            foreach (CheckBox check in this.panel1.Controls)
            {
                this.checkboxes.Add(check);
                check.Click += SumarNumeros;
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            CheckBox botonPulsado = (CheckBox)sender;
            int numero = int.Parse(botonPulsado.Text);
            if (botonPulsado.Checked)
            {
                int suma = int.Parse(this.txtSuma.Text);
                suma += numero;

                this.txtSuma.Text = suma.ToString();
            }
            else
            {
                int resta = int.Parse(this.txtSuma.Text);
                resta -= numero;

                this.txtSuma.Text = resta.ToString();

            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            foreach (CheckBox check in this.checkboxes)
            {
                int aleat = random.Next(1, 50);
                check.Text = aleat.ToString();
            }
        }
    }
}
