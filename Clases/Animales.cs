using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Animales
    {
        //atributos de la clase

        /// <summary>
        /// Obtiene y establece el id Animal
        /// </summary>
        public string Id{get ; set;}

        /// <summary>
        ///  Obtiene y establece la raza Animal
        /// </summary>
        public string Raza { get; set; }

        /// <summary>
        ///  Obtiene y establece la edad del Animal
        /// </summary>
        public double EdadAnimal { get; set; }

        /// <summary>
        /// Contructor por defecto de la clase
        /// </summary>
        public Animales () { }

        public Animales (string id_p, string raza_p, double edadAnimal_p)
        {
            this.Id = id_p;
            this.Raza = raza_p;
            this.EdadAnimal = edadAnimal_p;
        }

        public string ObtenerInfoAnimal()
        {
            return $"ID: ({Id}), Raza: ({Raza}), Edad: ({EdadAnimal})";
            // return $"{GetNombre()} {GetCedula()} {GetEdad()}";

        }

    }
}
