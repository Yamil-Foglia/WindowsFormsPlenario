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
    public partial class TelefonoAdd : Form
    {
        private int personaID;
        public TelefonoAdd(int personaID)
        {
            InitializeComponent();
            this.personaID = personaID;
        }

        private void btnTelefonoAdd_Click(object sender, EventArgs e)
        {
            var flag = TelefonoCN.Add(tbNumeroDeTelefono.Text, this.personaID);

            if (flag)
            {
                TelefonoList formTelefonoList = new TelefonoList(this.personaID);
                formTelefonoList.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Ocurrió un error al agregar la persona, contacte con el servicio técnico");
            }
        }
    }
}
