using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FiguraGeometrica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GUARDAR_Click(object sender, EventArgs e)
        {
            // Enviamos un messagebox, para mostrar informacion al usuario que sus datos han sido guardados
            MessageBox.Show("Datos del usuario guardado con exito", "Exito.", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void DUBUJAR_Click(object sender, EventArgs e)
        {
            // Obtiene la ruta del directorio base del proyecto
            string directorioBase = AppDomain.CurrentDomain.BaseDirectory;
            // Imprimimos la ruta, para conocer donde se encuentra nuestro directorio
            Console.WriteLine("Ruta base: " + directorioBase);


            string rutaImagenRelativa = "";

            if (CUADRADO.Checked)
            {
                
                

                // Convinamos la dos rutas en donde tenemos nuestro proyecto y donde tenemos guardado nuestras imagenes
                rutaImagenRelativa = Path.Combine(directorioBase, @"..\..\imagenes\circulo.jpg");
            }
            if (TRIANGULO.Checked)
            {
                
               
                rutaImagenRelativa = Path.Combine(directorioBase, @"..\..\imagenes\triangulo.jpg");
            }
            if (RECTANGULO.Checked)
            {
              

                rutaImagenRelativa = Path.Combine(directorioBase, @"..\..\imagenes\Rectangulo.png");
            }


        }

        //private void CUADRADO_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void RECTANGULO_CheckedChanged(object sender, EventArgs e)
        //{

        //}
    }
}
