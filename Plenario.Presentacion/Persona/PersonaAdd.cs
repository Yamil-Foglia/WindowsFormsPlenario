using Plenario.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plenario.Presentacion.Persona
{
    public partial class PersonaAdd : Form
    {
        public PersonaAdd()
        {
            InitializeComponent();
        }

        private void btnPeronaAdd_Click(object sender, EventArgs e)
        {
            PersonaCN.AddPersona(tbNombre.Text, dtpFechaDeNacimiento.Value, decimal.Parse(tbCreditoMaximo.Text));
        }

    }
}
