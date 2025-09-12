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
        //Declaracion variables
        string vTelefono;
        string vContacto;
        //Vectores
        string[] vecTelefono;
        string[] vecContacto;
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
    }
}
