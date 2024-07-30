using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Poo_Interfaces_Ejercicios1.Models;

    public class Coder
{
    public Guid Id { get; set; }
    public string Nombre { get; set; }

    public string Apellido { get; set; }

    public string Email { get; set; }
    public string Telefono { get; set; }

    public Coder(string nombre, string apellido, string email, string telefono)
    {
        Id = Guid.NewGuid();
        Nombre = nombre;
        Apellido = apellido;
        Email = email;
        Telefono = telefono;
    }
}
