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
    public partial class TelefonoDelete : Form
    {
        private Entidad.Telefono telefono;
        public TelefonoDelete(Entidad.Telefono telefono)
        {
            InitializeComponent();
            this.telefono = telefono;

            tbNumeroDeTelefono.Text = telefono.Telefono1;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var flag = TelefonoCN.Delete(this.telefono);

            if (flag)
            {
                MessageBox.Show("El telefono fue eliminado con éxito");
                TelefonoList formTelefonoList = new TelefonoList(this.telefono.PersonaID);
                formTelefonoList.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al eliminar el teléfono, contacte con el servicio técnico");
            }
            
        }
    }
}
