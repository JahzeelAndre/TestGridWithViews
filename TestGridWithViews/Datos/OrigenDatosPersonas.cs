using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGridWithViews.Modelos;

namespace TestGridWithViews.Datos
{
    internal class OrigenDatosPersonas
    {
        public static List<Personas> ListaPersonas = new List<Personas>
        {
            new Personas 
            { 
                Id = 1,
                FirstName = "Jahzeel",
                LastName = "Yibale",
                Age = 23,
                Cargo = "Practicante",
                Es = "Cliente"
            },
            new Personas
            {
                Id = 2,
                FirstName = "Brenda",
                LastName = "Soto",
                Age = 23,
                Cargo = "Practicante",
                Es = "Proveedor"
            },
            new Personas
            {
                Id = 3,
                FirstName = "Sergio",
                LastName = "Luna",
                Age = 30,
                Cargo = "Jefazo",
                Es = "Proveedor"
            }
        };
    }
}
