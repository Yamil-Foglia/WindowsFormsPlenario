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
    public partial class PersonaList : Form
    {
        public PersonaList()
        {
            InitializeComponent();

            dgListPersona.DataSource = null;
            dgListPersona.Rows.Clear();
            List<Entidad.Persona> personaList = PersonaCN.Get();

            this.GenerateList(personaList);
        }

        private void listPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgListPersona.DataSource = null;
            dgListPersona.Rows.Clear();
            List<Entidad.Persona> personaList = PersonaCN.GetForName(tbNombreFiltro.Text);

            this.GenerateList(personaList);
        }

        private void btnListSinFiltros_Click(object sender, EventArgs e)
        {
            dgListPersona.DataSource = null;
            dgListPersona.Rows.Clear();
            List<Entidad.Persona> personaList = PersonaCN.Get();
            this.GenerateList(personaList);
            tbNombreFiltro.Text = " ";
        }

        private void GenerateList(List<Entidad.Persona> personaList)
        {
            foreach (Entidad.Persona persona in personaList)
            {
                int i = dgListPersona.Rows.Add();
                dgListPersona.Rows[i].Cells[0].Value = persona.Nombre;
                dgListPersona.Rows[i].Cells[1].Value = persona.FechaNacimiento.ToString();
                dgListPersona.Rows[i].Cells[2].Value = persona.CreditoMaximo.ToString();

            }
        }

        private void btnPersonaAdd_Click(object sender, EventArgs e)
        {
            PersonaAdd formPersonaAdd = new PersonaAdd();
            formPersonaAdd.Show();
            this.Hide();
        }

        private void dgListPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Entidad.Persona> personaList = PersonaCN.Get();
            Entidad.Persona peronsa = personaList[e.RowIndex];

            if (dgListPersona.Columns[e.ColumnIndex].Name== "btnModify")
            {
                PersonaModify formPersonaModify = new PersonaModify(peronsa);
                formPersonaModify.Show();
                this.Hide();
            }

            if (dgListPersona.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                PersonaDelete formPersonaDelete = new PersonaDelete(peronsa);
                formPersonaDelete.Show();
                this.Hide();
            }

            if (dgListPersona.Columns[e.ColumnIndex].Name == "btnTelefonos")
            {
                Telefono.TelefonoList formTelefonoList = new Telefono.TelefonoList(peronsa.PersonaID);
                formTelefonoList.Show();
                this.Hide();
            }

        }

        private void btnGoToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
