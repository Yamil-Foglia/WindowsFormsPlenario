using Plenario.Datos;
using Plenario.Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plenario.Negocios
{
    public class PersonaCN
    {
        public static bool Add(string nombre, DateTime fechaDeNacimiento, decimal creditoMaximo)
        {
            PersonaDALC personaDALC = new PersonaDALC();

            var nuevaPersona = new Persona();
            nuevaPersona.Nombre = nombre;
            nuevaPersona.FechaNacimiento = fechaDeNacimiento;
            nuevaPersona.CreditoMaximo = creditoMaximo;

            return personaDALC.Add(nuevaPersona);
        }
        public static bool Delete(Persona persona)
        {
            PersonaDALC personaDALC = new PersonaDALC();

            return personaDALC.Delete(persona);
        }

        public static bool Modify(Persona persona)
        {
            PersonaDALC personaDALC = new PersonaDALC();

            return personaDALC.Modify(persona);
        }

        public static List<Persona> Get()
        {
            PersonaDALC personaDALC = new PersonaDALC();

            return personaDALC.Get();
        }
        public static List<Persona> GetForName(string nombre)
        {
            PersonaDALC personaDALC = new PersonaDALC();
            
            return personaDALC.GetForName(nombre);
        }
    }
}
