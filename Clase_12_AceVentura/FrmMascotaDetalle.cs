using Clase_12_AceVentura.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Clase_12_AceVentura
{
    public partial class FrmMascotaDetalle : Form
    {
        Animal animal;
        FrmListarMascotas frmListado;
        private bool esEdicion = false;

        public FrmMascotaDetalle(Animal animal, FrmListarMascotas frmListado)
        {
            InitializeComponent();
            VerificarTipoFormulario(animal);
            this.frmListado = frmListado;
        }

        private void VerificarTipoFormulario(Animal animal)
        {
            if (animal == null)
            {
                this.Text = "Crear un nuevo Registro";
                this.btnDeclararEncontrada.Enabled = false;
                this.btnDeclararEntregada.Enabled = false;

            }
            else
            {
                this.esEdicion = true;
                this.Text = "Modificar Registro";
                this.animal = animal;
                this.txtNombreAnimal.Text = animal.NombreAnimal;
                this.txtNombreDueno.Text = animal.DuenoAnimal;
                this.txtNumeroChip.Text = animal.NumeroChip.ToString();
                this.txtNumeroChip.ReadOnly = true;

                this.btnDeclararEncontrada.Enabled = true;
                this.btnDeclararEntregada.Enabled = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string validacion = ValidarControles();
            if (validacion == string.Empty)
            {
                if (!esEdicion)
                { 
                    animal = new Animal(int.Parse(txtNumeroChip.Text), txtNombreAnimal.Text, txtNombreDueno.Text); 
                }
                this.frmListado.AgregarMascotaYActualizar(animal);
                this.Close();
            }
            else
            {
                MessageBox.Show(validacion, "Faltan campos requeridos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private string ValidarControles()
        {
            string textoSalidaValidacion = string.Empty;
            if (txtNumeroChip.Text == string.Empty)
            {
                textoSalidaValidacion = textoSalidaValidacion + "Falta campo requerido: Número del Chip" + Environment.NewLine;
            }

            if (txtNombreDueno.Text == string.Empty)
            {
                textoSalidaValidacion = textoSalidaValidacion + "Falta campo requerido: Nombre del Dueño" + Environment.NewLine;
            }

            if (txtNombreAnimal.Text == string.Empty)
            {
                textoSalidaValidacion = textoSalidaValidacion + "Falta campo requerido: Nombre del Animal" + Environment.NewLine;
            }

            int numeroChipValidar = 0;
            if (Int32.TryParse(txtNumeroChip.Text, out numeroChipValidar) == false)
            {
                textoSalidaValidacion = textoSalidaValidacion + "Número del Chip no es válido" + Environment.NewLine;
            }

            return textoSalidaValidacion;

        }

        private void btnDeclararEncontrada_Click(object sender, EventArgs e)
        {
            this.animal.Recuperar();
            this.btnDeclararEntregada.Enabled = true;
        }

        private void btnDeclararEntregada_Click(object sender, EventArgs e)
        {
            this.animal.EntregadoADueno();
        }
    }
}
