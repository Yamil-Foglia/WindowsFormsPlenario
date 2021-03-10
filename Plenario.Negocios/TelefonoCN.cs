using Plenario.Datos;
using Plenario.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plenario.Negocios
{
    public class TelefonoCN
    {
        public static bool Add(string numeroDeTelefono, int personaID)
        {
            TelefonoDALC telefonoDALC = new TelefonoDALC();

            var nuevoTelefono = new Telefono();
            nuevoTelefono.Telefono1 = numeroDeTelefono;
            nuevoTelefono.PersonaID = personaID;

            return telefonoDALC.Add(nuevoTelefono);
        }

        public static bool Delete(Telefono telefono)
        {
            TelefonoDALC telefonoDALC = new TelefonoDALC();

            return telefonoDALC.Delete(telefono);
        }
        public static bool Modify(Telefono telefono)
        {
            TelefonoDALC telefonoDALC = new TelefonoDALC();

            return telefonoDALC.Modify(telefono);
        }

        public static List<Telefono> Get(int personaID)
        {
            TelefonoDALC telefonoDALC = new TelefonoDALC();

            return telefonoDALC.Get(personaID);
        }


    }
}
