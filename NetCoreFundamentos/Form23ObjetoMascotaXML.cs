using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NetCoreFundamentos
{
    public partial class Form23ObjetoMascotaXML : Form
    {
        XmlSerializer serializer;
        private string imagenBase64;
        public Form23ObjetoMascotaXML()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(Mascota));
        }

        private void btnLeerClase_Click(object sender, EventArgs e)
        {
            Mascota mascota = null;
            using (StreamReader reader = new StreamReader("mascota.xml"))
            {
                mascota = (Mascota)this.serializer.Deserialize(reader);
                reader.Close();
                this.txtNombre.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
                this.txtEdad.Text = mascota.Edad.ToString();
                byte[] imageBytes = Convert.FromBase64String(mascota.Imagen);
                using (MemoryStream ms = new MemoryStream(imageBytes))
                {
                    this.pictureBox1.Image = Image.FromStream(ms);
                }
            }
        }

        private async void btnGuardarClase_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);
            mascota.Imagen = this.imagenBase64;
     
            //las clases que se utilizan son de tipo stream
            //para escribir necesitamos la clase streamWriter
            using (StreamWriter writer = new StreamWriter("mascota.xml"))
            {
                this.serializer.Serialize(writer, mascota);
                await writer.FlushAsync();
                writer.Close();
            }
            this.txtNombre.Text = "";
            this.txtRaza.Text = "";
            this.txtEdad.Text = "";
            this.imagenBase64 = null;
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string path = this.openFileDialog1.FileName;
                this.pictureBox1.Image = Image.FromFile(path);


                byte[] imageBytes = File.ReadAllBytes(path);
                this.imagenBase64 = Convert.ToBase64String(imageBytes);
            }
        }
    }
}
