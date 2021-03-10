using Plenario.Datos.Data;
using Plenario.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plenario.Datos
{
    public class TelefonoDALC
    {
        public bool Add(Telefono telefono)
        {
            using (PlenarioEntities mainContext = new PlenarioEntities())
            {
                try
                {
                    mainContext.Telefono.Add(telefono);
                    mainContext.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool Modify(Telefono telefono)
        {
            using (PlenarioEntities mainContext = new PlenarioEntities())
            {
                try
                {
                    var telefonoModicado = mainContext.Telefono.ToList().Where(x => x.TelefonoID == telefono.TelefonoID).FirstOrDefault();

                    telefonoModicado.Telefono1 = telefono.Telefono1;

                    mainContext.Entry(telefonoModicado).State = System.Data.Entity.EntityState.Modified;
                    mainContext.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool Delete(Telefono telefono)
        {
            using (PlenarioEntities mainContext = new PlenarioEntities())
            {
                try
                {
                    var telefonoElimando = mainContext.Telefono.ToList().Where(x => x.TelefonoID == telefono.TelefonoID).FirstOrDefault();

                    mainContext.Telefono.Remove(telefonoElimando);

                    mainContext.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List<Telefono> Get(int personaID)
        {
            using (PlenarioEntities mainContext = new PlenarioEntities())
            {
                var telefonos = mainContext.Telefono.ToList().Where(x => x.PersonaID == personaID);
                return telefonos.ToList();
            }
        }
    }
}
