using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<Button> botones;
        List<TextBox> txt;
        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            this.botones = new List<Button>();
            this.txt = new List<TextBox>();
            foreach (Control ctrl in this.Controls)
            {
               if(ctrl is Button)
                {
                    this.botones.Add((Button)ctrl);
                }
                else
                {
                    this.txt.Add((TextBox)ctrl);
                }

                
            }
            
        }

        private void GenerarTabla(object? sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            int i = 1;
            foreach(TextBox text in txt)
            {
               // text.Text = (int.Parse(boton));
            }
        }
    }
}
