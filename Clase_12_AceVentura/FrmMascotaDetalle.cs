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
        List<IAnimal> animales;

        public FrmMascotaDetalle(Animal animal, List<IAnimal> animales)
        {
            InitializeComponent();
            VerificarTipoFormulario(animal);
            this.animales = animales;
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
                this.Text = "Modificar Registro";
                this.animal = animal;
                this.btnDeclararEncontrada.Enabled = true;
                this.btnDeclararEntregada.Enabled = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string validacion = ValidarControles();
            if (validacion == string.Empty)
            {
                animal = new Animal(int.Parse(txtNumeroChip.Text), txtNombreAnimal.Text, txtNombreDueno.Text);
                animales.Add(animal);
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
    }
}
