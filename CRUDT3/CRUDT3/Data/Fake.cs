using System.Collections.Generic;
using CRUDT3.Models;

namespace CRUDT3.Data
{
    public static class FakeDb
    {
        public static List<Contactomodel> Contactos { get; } = new List<Contactomodel>
        {
            new Contactomodel { IdContacto = 1, Nombre = "Juan", Telefono = "809-111-1111", Correo = "juan@mail.com" },
            new Contactomodel { IdContacto = 2, Nombre = "María", Telefono = "809-222-2222", Correo = "maria@mail.com" }
        };
    }
}
