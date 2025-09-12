using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pry.Agenda.Molina
{
    public partial class Agenda : Form
    {
        //Declaracion variables globales
        string vTelefono;
        string vContacto;
        DateTime vFecha = DateTime.Now;
        int vCantContactos = 0;
        //Vectores
        string[] vecTelefono = new string[5];
        string[] vecContacto = new string[5];
        //indice
        int indice = 0;

        public Agenda()
        {
            InitializeComponent();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                mskNúmero.Enabled = true;
            }
            else
            {
                mskNúmero.Enabled = false;
            }
        }

        private void mskNúmero_TextChanged(object sender, EventArgs e)
        {
            if (mskNúmero.MaskFull == true)
            {
                btnRegistrar.Enabled = true;
            }
            else
            {
                btnRegistrar.Enabled = false;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            vecTelefono[indice] = mskNúmero.Text;
            vecContacto[indice] = txtNombre.Text;
            lstResultados.Items.Add("Contacto: " + vecContacto[indice] + " - Telefono: " + vecTelefono[indice]);
            txtNombre.Text = "";
            mskNúmero.Text = "";
            indice = indice + 1;
            btnRegistrar.Enabled = false;
            vCantContactos = vCantContactos + 1;
            lblCantContact.Text = ("Cantidad de contactos: " + vCantContactos);
            lblFecha.Text = ("Fecha y hora: " + vFecha);
            txtNombre.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            mskNúmero.Text = "";
        }
    }
}
