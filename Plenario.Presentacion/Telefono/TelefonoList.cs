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

namespace Plenario.Presentacion.Telefono
{
    public partial class TelefonoList : Form
    {
        private int personaID;
        public TelefonoList(int personaID)
        {
            InitializeComponent();

            this.personaID = personaID;

            dgListTelefono.DataSource = null;
            dgListTelefono.Rows.Clear();
            List<Entidad.Telefono> telefonoList = TelefonoCN.Get(this.personaID);

            this.GenerateList(telefonoList);
        }

        private void GenerateList(List<Entidad.Telefono> telefonoList)
        {
            foreach (Entidad.Telefono telefono in telefonoList)
            {
                int i = dgListTelefono.Rows.Add();
                dgListTelefono.Rows[i].Cells[0].Value = telefono.Telefono1;
            }
        }

        private void dgListTelefono_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<Entidad.Telefono> telefonoList = TelefonoCN.Get(this.personaID);
            Entidad.Telefono telefono = telefonoList[e.RowIndex];

            if (dgListTelefono.Columns[e.ColumnIndex].Name == "btnModify")
            {
                TelefonoModify formTelefonoModify = new TelefonoModify(telefono);
                formTelefonoModify.Show();
                this.Hide();
            }

            if (dgListTelefono.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                TelefonoDelete formTelefonoDelete = new TelefonoDelete(telefono);
                formTelefonoDelete.Show();
                this.Hide();
            }
        }

        private void btnGoToHome_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnTelefonoAdd_Click(object sender, EventArgs e)
        {
            TelefonoAdd formTelfonoAdd = new TelefonoAdd(this.personaID);
            formTelfonoAdd.Show();
            this.Hide();
        }

        private void btnGoToListPersonas_Click(object sender, EventArgs e)
        {
            Persona.PersonaList formPersonaList = new Persona.PersonaList();
            formPersonaList.Show();
            this.Hide();
        }
    }
}
