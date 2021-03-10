using Plenario.Presentacion.Persona;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plenario.Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGoToFormPeronsaAdd_Click(object sender, EventArgs e)
        {
            PersonaAdd formPersonaAdd = new PersonaAdd();
            formPersonaAdd.Show();

        }

        private void btnGoToListPersona_Click(object sender, EventArgs e)
        {
            PersonaList formPersonaList = new PersonaList();
            formPersonaList.Show();
        }
    }
}
