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
        List<Animal> listaAnimales;
        public FrmListarMascotas(List<Animal> listaAnimales)
        {
            this.listaAnimales = listaAnimales;
            MockListaMascotas();
            InitializeComponent();
            MostrarGrilla();
            MostrarGrilla();
        }

        private void btnNewPet_Click(object sender, EventArgs e)
        {
            FrmMascotaDetalle detail = new FrmMascotaDetalle(null, this);
            detail.MdiParent = this.MdiParent;
            detail.Show();
        }

        private void MockListaMascotas()
        {
            listaAnimales.Add(new Animal(1234, "Tommy", "El Vecino"));
            listaAnimales.Add(new Animal(238, "Leo", "El Vecino 2"));
            listaAnimales.Add(new Animal(5247, "Luna", "El Vecino 3"));
            listaAnimales.Add(new Animal(8851, "Titi", "El Vecino 4"));
        }

        private void MostrarGrilla()
        {
            // Vamos a limpiar los elementos de la Grilla
            lstMascotasPerdidas.Items.Clear();

            foreach (Animal animal in listaAnimales)
            {
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

                item.SubItems.Add(animal.EstaPerdido ? "No se ha encontrado" : "Mascota encontrada");
                item.SubItems.Add(!animal.EstaEntregado ? "No se ha entregado" : "Mascota feliz con su dueño");


            }
        }

        public void AgregarMascotaYActualizar(Animal animal)
        {
            Animal animalAnterior = listaAnimales.Where(animalLista =>
                        animalLista.NumeroChip == animal.NumeroChip).FirstOrDefault();
            if (animalAnterior == null)
            {
                listaAnimales.Add(animal);
            }
            else {
                animalAnterior.EstaPerdido = animal.EstaPerdido;
                animalAnterior.DuenoAnimal = animal.DuenoAnimal;
                animalAnterior.EstaEntregado = animal.EstaEntregado;
                animalAnterior.NombreAnimal = animal.NombreAnimal;

                /*
                listaAnimales.Remove(animalAnterior);
                listaAnimales.Add(animal);*/
            }

            
            MostrarGrilla();
        }

        private void lstMascotasPerdidas_SelectedIndexChanged(object sender, EventArgs e)
        {  
            if (lstMascotasPerdidas.SelectedItems != null) {
                int numeroChip = Convert.ToInt32(lstMascotasPerdidas.SelectedItems[0].Text);

                // Vamos a buscar nuestro Objeto usando esa referencia en nuestra lista
                Animal animalABuscar = listaAnimales.Where(elementoBusqueda =>
                                    elementoBusqueda.NumeroChip == numeroChip)
                                    .FirstOrDefault();

                FrmMascotaDetalle detail = new FrmMascotaDetalle(animalABuscar, this);
                detail.MdiParent = this.MdiParent;
                detail.Show();
            }

        }
    }
}
