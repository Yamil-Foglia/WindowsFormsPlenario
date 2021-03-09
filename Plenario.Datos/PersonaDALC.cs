using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plenario.Datos.Data;
using Plenario.Entidad;

namespace Plenario.Datos
{
    public class PersonaDALC
    {
        public void AddPersona(Persona persona)
        {
            using (PlenarioEntities db = new PlenarioEntities())
            {
                db.Persona.Add(persona);
                db.SaveChanges();
            }
        }

        public List<Persona> GetPersonas()
        {
            using(PlenarioEntities db = new PlenarioEntities())
            {
                return db.Persona.ToList();
            }
        }
    }
}
