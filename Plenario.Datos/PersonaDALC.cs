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
        public bool Add(Persona persona)
        {
            using (PlenarioEntities mainContext = new PlenarioEntities())
            {
                try
                {
                    mainContext.Persona.Add(persona);
                    mainContext.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool Modify(Persona persona)
        {
            using (PlenarioEntities mainContext = new PlenarioEntities())
            {
                try
                {
                    var personaModicada = mainContext.Persona.ToList().Where(x => x.PersonaID == persona.PersonaID).FirstOrDefault();

                    personaModicada.Nombre = persona.Nombre;
                    personaModicada.FechaNacimiento = persona.FechaNacimiento;
                    personaModicada.CreditoMaximo = persona.CreditoMaximo;

                    mainContext.Entry(personaModicada).State = System.Data.Entity.EntityState.Modified;
                    mainContext.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public bool Delete(Persona persona)
        {
            using (PlenarioEntities mainContext = new PlenarioEntities())
            {
                try
                {
                    var personaElimanda = mainContext.Persona.ToList().Where(x => x.PersonaID == persona.PersonaID).FirstOrDefault();
                    mainContext.Persona.Remove(personaElimanda);
                    mainContext.SaveChanges();

                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public List<Persona> Get()
        {
            using(PlenarioEntities mainContext = new PlenarioEntities())
            {
                return mainContext.Persona.ToList();
            }
        }

        public List<Persona> GetForName(string nombre)
        {
            using (PlenarioEntities mainContext = new PlenarioEntities())
            {
                var personas = mainContext.Persona.ToList().Where(x => x.Nombre.ToLower() == nombre.ToLower());
                return personas.ToList();
            }
        }
    }
}
