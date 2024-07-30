using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Poo_Interfaces_Ejercicios1.interfaces;

namespace Poo_Interfaces_Ejercicios1.Models;

    public class Coder: ICrudCoder
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

    public void CreateCoder()
    {
        throw new NotImplementedException();
    }

    public void ReadCoder()
    {
        Console.WriteLine($"Id: {Id}, Nombre: {Nombre}, Apellido: {Apellido}, Email: {Email}, Telefono: {Telefono}");

    }

    public void UpdateCoder()
    {
        Console.WriteLine("Ingrese los nuevos datos:");
    
    }

    public void DeleteCoder()
    {
        throw new NotImplementedException();
    }
}
