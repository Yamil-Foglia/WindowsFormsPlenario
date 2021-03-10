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
    public partial class PersonaDelete : Form
    {
        private Entidad.Persona persona;
        public PersonaDelete(Entidad.Persona persona)
        {
            InitializeComponent();

            this.persona = persona;

            tbNombre.Text = persona.Nombre;
            tbFechaDeNacimiento.Text = persona.FechaNacimiento.ToString();
            tbCreditoMaximo.Text = persona.CreditoMaximo.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var flag = PersonaCN.Delete(this.persona);

            if (flag)
            {
                MessageBox.Show("La persona fue eliminada con éxito");
                PersonaList formPersonaList = new PersonaList();
                formPersonaList.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al eliminar la persona, contacte con el servicio técnico");
            }

        }

        private void btnGoToListPersonas_Click(object sender, EventArgs e)
        {
            PersonaList formPersonaList = new PersonaList();
            formPersonaList.Show();
            this.Hide();
        }
    }
}
