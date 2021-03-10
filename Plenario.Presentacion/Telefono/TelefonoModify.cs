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
    public partial class TelefonoModify : Form
    {
        private Entidad.Telefono telefono;
        public TelefonoModify(Entidad.Telefono telefono)
        {
            InitializeComponent();
            this.telefono = telefono;

            tbNumeroDeTelefono.Text = telefono.Telefono1;
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            this.telefono.Telefono1 = tbNumeroDeTelefono.Text;

            var flag = TelefonoCN.Modify(this.telefono);

            if (flag)
            {
                MessageBox.Show("El teléfono fue modificada con éxito");
                TelefonoList formTelefonoList = new TelefonoList(this.telefono.PersonaID);
                formTelefonoList.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al modificar el teléfono, contacte con el servicio técnico");
            }
        }

        private void btnGoToListTelefono_Click(object sender, EventArgs e)
        {
            TelefonoList formTelefonoList = new TelefonoList(this.telefono.PersonaID);
            formTelefonoList.Show();
            this.Hide();
        }

        
    }
}
