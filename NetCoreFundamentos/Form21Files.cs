using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;


using ProyectoClases.Helper;

namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {
     
        public string Path { get; set; }

        HelperFiles helper;

        public Form21Files()
        {
            InitializeComponent();
            this.helper = new HelperFiles();
            //Cuando hablamos de ruta o caracteres especiales
            //dentro de string tenemos 2 formas de scribir dichos caracteres
            //1) C:\carpeta\1.txt
            //this.Path = "C:\\carpeta\\1.txt";
            //2)utilizar @ antes del string y fuera del string
            //this.Path = @"C:\carpeta\1.txt";
            this.Path = "file1.txt";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevoNombre_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

        private async void btnLeerFile_Click(object sender, EventArgs e)
        {
            string content = await this.helper.ReadFileAsync(this.Path);
            this.txtContenido.Text = content;
           string[] nombres= content.Split(',');
            this.lstNombres.Items.Clear();
            foreach(string name in nombres)
            {
                this.lstNombres.Items.Add(name);
            }
        }

        private async void btnWriteFile_Click(object sender, EventArgs e)
        {
            string content = this.GetNombresListBox();
            await this.helper.WriteFileAsync(this.Path, content);
            MessageBox.Show("Datos almacenados");
        }
        public string GetNombresListBox()
        {
            string data = "";
            foreach(string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }
    }
}
