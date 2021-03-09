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
        public static void AddPersona(string nombre, DateTime fechaDeNacimiento, decimal creditoMaximo)
        {
            PersonaDALC personaDALC = new PersonaDALC();

            var nuevaPersona = new Persona();
            nuevaPersona.Nombre = nombre;
            nuevaPersona.FechaNacimiento = fechaDeNacimiento;
            nuevaPersona.CreditoMaximo = creditoMaximo;

            personaDALC.AddPersona(nuevaPersona);
        }
        public static List<Persona> GetPersonas()
        {
            PersonaDALC personaDALC = new PersonaDALC();

            return personaDALC.GetPersonas();
        }
    }
}
