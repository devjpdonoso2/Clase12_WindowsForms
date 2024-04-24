using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_12_AceVentura.Classes
{
    public class Animal : IAnimal
    {
        public int NumeroChip { get; set; }
        public string NombreAnimal { get; set; }
        public string DuenoAnimal { get; set; }
        public bool EstaEntregado { get; set; }
        public bool EstaPerdido { get; set; }

        public Animal(int numeroChip, string nombreAnimal, string duenoAnimal) {
            this.EstaEntregado = false;
            this.EstaPerdido = true;
            this.NumeroChip = numeroChip;
            this.NombreAnimal = nombreAnimal;
            this.DuenoAnimal = duenoAnimal;
        }

        public void EntregadoADueno()
        {
            this.EstaEntregado = true;
        }

        public void Recuperar()
        {
            this.EstaPerdido = false;
        }
    }
}
