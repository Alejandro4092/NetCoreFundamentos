
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases.Helper;
using ProyectoClases.Models;

namespace NetCoreFundamentos
{
    public partial class Form22MascotasFiles : Form
    {
        HelperMacotas helper;
        public Form22MascotasFiles()
        {
            InitializeComponent();
            this.helper = new HelperMacotas();
        }
        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.helper.Mascotas)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private async void btnNuevaMascota_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtMascota.Text;
            mascota.Raza = this.txtRaza.Text;
            this.helper.Mascotas.Add(mascota);
            this.DibujarMascotas();

        }

        private async void btnReadFile_Click(object sender, EventArgs e)
        {
            await this.helper.ReadMascotasAsync();
            this.DibujarMascotas();
        }

        private async void btnWriteFile_ClickAsync(object sender, EventArgs e)
        {
            await this.helper.WriteMascotasAsync();
            this.lstMascotas.Items.Clear();

        }

        private void lstMascotas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.lstMascotas.SelectedIndex;
            if (index != -1)
            {
                Mascota mascota = this.helper.Mascotas[index];
                this.txtMascota.Text = mascota.Nombre;
                this.txtRaza.Text = mascota.Raza;
            }
        }

        private void txtMascota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
