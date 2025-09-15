using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.Agenda.Molina
{
    public partial class VerContacto : Form
    {
        public VerContacto()
        {
            InitializeComponent();
        }
        //Declaracion de vector
        int indice = 0;
        string[] vecNombre = new string[3];

        private void lblVerContacto_Click(object sender, EventArgs e)
        {
            //Cargar vector
            vecNombre[0] = "Juan Perez";
            vecNombre[1] = "Maria Gomez";
            vecNombre[2] = "Carlos Sanchez";
            //Mostrar primer contacto
            lblVerContacto.Text = vecNombre[0];
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            //sumar indice (indice = indice + 1)
            indice++;

            lblVerContacto.Text = vecNombre[indice];

            
            if (vecNombre.Length <= (indice + 1))
            //siempre que este en el ultimo contacto
            {
                btnSiguiente.Enabled = false;
            }
            else //se habilita el boton atras
                 //siempre que no este en el primer contacto
            {
                btnAtras.Enabled = true;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //restar indice (indice = indice - 1)
            indice--;
            lblVerContacto.Text = vecNombre[indice];
            //siempre que no este en el primer contacto
            if (indice == 0)
            {
                btnAtras.Enabled = false;
            }
            else //se habilita el boton siguiente
            {
                btnSiguiente.Enabled = true;
            }
        }
    }
}
