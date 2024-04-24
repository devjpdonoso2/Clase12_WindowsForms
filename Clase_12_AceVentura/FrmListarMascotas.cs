using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clase_12_AceVentura.Classes;

namespace Clase_12_AceVentura
{
    public partial class FrmListarMascotas : Form
    {
        List<IAnimal> listaAnimales;
        public FrmListarMascotas(List<IAnimal> listaAnimales)
        {
            this.listaAnimales = listaAnimales;
            MockListaMascotas();
            InitializeComponent();
            MostrarGrilla();
        }

        private void btnNewPet_Click(object sender, EventArgs e)
        {
            FrmMascotaDetalle detail = new FrmMascotaDetalle(null, listaAnimales);
            detail.MdiParent = this.MdiParent;
            detail.Show();
        }

        private void MockListaMascotas() {
            listaAnimales.Add(new Animal(1234, "Tommy", "El Vecino"));
            listaAnimales.Add(new Animal(238, "Leo", "El Vecino 2"));
            listaAnimales.Add(new Animal(5247, "Luna", "El Vecino 3"));
            listaAnimales.Add(new Animal(8851, "Titi", "El Vecino 4"));
        }

        private void MostrarGrilla() {

            foreach (Animal animal in listaAnimales) { 
                ListViewItem item = new ListViewItem();
                item = lstMascotasPerdidas.Items.Add(animal.NumeroChip.ToString());
                item.SubItems.Add(animal.NombreAnimal);
                item.SubItems.Add(animal.DuenoAnimal);

                /*
                if (animal.EstaPerdido == true)
                {
                    item.SubItems.Add("No se ha encontrado");
                }
                else {
                    item.SubItems.Add("Mascota encontrada");
                }*/

                item.SubItems.Add(animal.EstaPerdido? "No se ha encontrado" : "Mascota encontrada");
                item.SubItems.Add(!animal.EstaEntregado ? "No se ha entregado" : "Mascota feliz con su dueño");


            }
        }
    }
}
