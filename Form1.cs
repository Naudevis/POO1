using POO.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Form1 : Form
    {
        Animales animal = new Animales(); // instancia
        // Creamos una lista de tipo animal
        List<Animales> animalitos = new List<Animales>();

        int indice = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Animales animal = new Animales("2000", "Pastor Aleman", 10);
            txtId.Text = animal.Id;
            txtRaza.Text = animal.Raza;
            txtEdadAnimal.Text = Convert.ToString(animal.EdadAnimal);
        }
        private void btnPOO_Click(object sender, EventArgs e)
        {
            Persona persona1 = new Persona();
            Persona persona2 = new Persona("12345678", "Jehudy Cajina Guevara", 29);

            txtNombre.Text = persona2.GetNombre();
            txtCedula.Text = persona2.GetCedula();
            txtEdad.Text = Convert.ToString(persona2.GetEdad());
        }



        private void btnAsignar_Click_1(object sender, EventArgs e)
        {
            Persona persona1 = new Persona();
            persona1.SetNombre(txtNombre.Text);
            persona1.SetCedula(txtCedula.Text);
            persona1.SetEdad(Convert.ToDouble(txtEdad.Text));

            MessageBox.Show(persona1.ObtenerInfoPersona());
        }

        private void btnEstablecerValores_Click(object sender, EventArgs e)
        {

            animal.Raza = txtRaza.Text;
            animal.Id = txtId.Text;
            animal.EdadAnimal = Convert.ToDouble(txtEdadAnimal.Text);
            MessageBox.Show(btnEstablecerValores.Text = "Nuevo texto del boton");
        }

        private void btnMostrarValores_Click(object sender, EventArgs e)
        {
            Console.WriteLine($"{animal.Id} {animal.Raza} {animal.EdadAnimal}");
            MessageBox.Show($"{animal.ObtenerInfoAnimal()}");
        }

        private void btnAgregarAnimal_Click(object sender, EventArgs e)
        {
            string IdAnimal = txtId.Text;
            string RazaAnimal = txtRaza.Text;
            string EdadAnimal = txtEdadAnimal.Text;


            // Creamos la instancia con los valores que tiene los txt

            if (IdAnimal != "Error" || RazaAnimal != "Error" || EdadAnimal != "Error")
            {



                Animales animalitoGuardar = new Animales(
                txtId.Text,
                txtRaza.Text,
               Convert.ToDouble(txtEdadAnimal.Text)

                );
                animalitos.Add(animalitoGuardar);

                dtAnimales.Rows.Clear();

                foreach (Animales animal in animalitos)
                {

                    dtAnimales.Rows.Add(animal.Id, animal.Raza, animal.EdadAnimal);
                }

                txtId.Text = "ID";
                txtRaza.Text = "Raza";
                txtEdadAnimal.Text = "Edad";

                txtId.ForeColor = Color.Gray;
                txtRaza.ForeColor = Color.Gray;
                txtEdadAnimal.ForeColor = Color.Gray;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Debes especifiar un id de animal");
            }
            else
            {
                animalitos.RemoveAll(Animal => Animal.Id == txtId.Text);
                Console.WriteLine("-------------------------------- Animalito eliminado---------------------------------------");

                foreach (Animales animal in animalitos)
                {

                    Console.WriteLine(animal.ObtenerInfoAnimal());
                }
                Console.WriteLine("--------------------------------Fin de impresión de animalitos---------------------------------------");

                txtId.Text = "";
                txtRaza.Text = "";
                txtEdadAnimal.Text = "";
            }
        }




        private void dtAnimales_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;// or FindIndex(animal => animal.Id == IdPerroEliminar) cuando se elimine
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {


            if (indice >= 0 && animalitos.Count>0)
            {
                animalitos.RemoveAt(indice);

                dtAnimales.Rows.Clear();

                foreach (Animales animal in animalitos)
                {

                    dtAnimales.Rows.Add(animal.Id, animal.Raza, animal.EdadAnimal);
                }
            }
        }
        private void txtRaza_TextChanged(object sender, EventArgs e)
        {
            txtRaza.ForeColor = Color.Black;
        }

        private void txtEdadAnimal_TextChanged(object sender, EventArgs e)
        {
            txtEdadAnimal.ForeColor = Color.Black;
        }

        private void txtId_Leave(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtId.Text))
            {
                txtId.ForeColor = Color.Gray;

            }
            else
            {
                txtId.Text = "Error";
                txtId.ForeColor = Color.Red;

            }
        }

        private void txtRaza_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtRaza.Text))
            {
                txtRaza.ForeColor = Color.Gray;

            }
            else
            {
                txtRaza.Text = "Error";
                txtRaza.ForeColor = Color.Red;

            }
        }

        private void txtEdadAnimal_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEdadAnimal.Text))
            {
                txtEdadAnimal.ForeColor = Color.Gray;

            }
            else
            {
                txtEdadAnimal.Text = "Error";
                txtEdadAnimal.ForeColor = Color.Red;

            }
        }

        private void txtId_TextChanged_1(object sender, EventArgs e)
        {
            txtId.ForeColor = Color.Black;

        }

        private void txtId_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "ID" || txtId.Text == "Error")
            {
                txtId.Text = "";
            }

        }

        private void txtRaza_Click(object sender, EventArgs e)
        {
            if (txtRaza.Text == "Raza" || txtRaza.Text == "Error")
            {
                txtRaza.Text = "";
            }
        }

        private void txtEdadAnimal_Click(object sender, EventArgs e)
        {
            if (txtEdadAnimal.Text == "Edad" || txtEdadAnimal.Text == "Error")
            {
                txtEdadAnimal.Text = "";
            }
        }
    }
}
