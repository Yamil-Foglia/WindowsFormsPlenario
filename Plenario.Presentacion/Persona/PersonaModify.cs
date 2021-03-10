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
    public partial class PersonaModify : Form
    {
        private Entidad.Persona persona;
        public PersonaModify(Entidad.Persona persona)
        {
            InitializeComponent();

            this.persona = persona;

            tbNombre.Text = persona.Nombre;
            tbFechaDeNacimiento.Text = persona.FechaNacimiento.ToString();
            tbCreditoMaximo.Text = persona.CreditoMaximo.ToString();
        }

        private void btnGoToListPersonas_Click(object sender, EventArgs e)
        {
            PersonaList formPersonaList = new PersonaList();
            formPersonaList.Show();
            this.Hide();
        }

        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            this.persona.Nombre = tbNombre.Text;
            this.persona.FechaNacimiento = DateTime.Parse(tbFechaDeNacimiento.Text);
            this.persona.CreditoMaximo = Decimal.Parse(tbCreditoMaximo.Text);

            var flag = PersonaCN.Modify(this.persona);

            if (flag)
            {
                MessageBox.Show("La persona fue modificada con éxito");
                PersonaList formPersonaList = new PersonaList();
                formPersonaList.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al modificar la persona, contacte con el servicio técnico");
            }

            
        }
    }
}
