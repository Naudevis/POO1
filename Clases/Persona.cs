using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO.Clases
{
    public class Persona
    {
        // esta compuesta por propiedades,constructores y métodos
        // 1.Propiedaddes o atributos de la clase
        private string cedula;
        private string nombre;
        private double edad;

        // Constructor de la clase (Por defecto)
        public Persona() { }

        // constructor por parámetro

        public Persona(string cedula_p, string nombre_p, double edad_p)
        {
            this.cedula = cedula_p;
            this.nombre = nombre_p;
            this.edad = edad_p;

        }
        //Métodos de la clase
        /// <summary>
        /// Método que retorna el nombre de la persona
        /// </summary>
        /// <returns>String(nombre de la persona)</returns>
        public string GetNombre()
        {
            return this.nombre;
        }

        /// <summary>
        /// Método que retorna la cédula de la persona
        /// </summary>
        /// <returns>String(cédula de la persona)</returns>
        public string GetCedula()
        {
            return this.cedula;
        }

        /// <summary>
        /// Método que retorna la edad de la persona
        /// </summary>
        /// <returns>Double(edad de la persona)</returns>
        public double GetEdad()
        {
            return this.edad;
        }

        //Métodos Set de la clase para establecer valores a los atributos

        /// <summary>
        /// Establece el valor que se le asignará a la cédula 
        /// </summary>
        /// <param name="cedula_p">Valor del tipo cadena</param>

        public void SetCedula(string cedula_p)
        {
            this.cedula = cedula_p;
        }


        /// <summary>
        /// Método que asigna el nombre a la persona
        /// </summary>
        /// <param name="nombre_p">Valor del tipo cadena</param>
        public void SetNombre(string nombre_p)
        {
            this.nombre = nombre_p;
        }


        /// <summary>
        /// Método que asigna la edad de la persona a crear
        /// </summary>
        /// <param name="edad_p">Valor del tipon double</param>
        public void SetEdad(double edad_p)
        {
            this.edad = edad_p;
        }

        /// <summary>
        /// Método que devuelve absolutamente todos los atributos de l persona
        /// </summary>
        /// <returns>String (cédula,nombre,edad)</returns>
        public string ObtenerInfoPersona()
        {
             return $"Nombre: {GetNombre()}, Cedula: {GetCedula()}, Edad: {GetEdad()}";
           // return $"{GetNombre()} {GetCedula()} {GetEdad()}";

        }
    }
}
