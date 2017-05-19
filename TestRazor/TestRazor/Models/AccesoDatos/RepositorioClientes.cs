using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestRazor.Common;

namespace TestRazor.Models.AccesoDatos
{
    public class RepositorioClientes
    {
        TestRazorEntities modelo = new TestRazorEntities();

        public RepositorioClientes()
        {
            modelo.Database.Log = Logger.Log;
        }

        public void guardar(Cliente cliente)
        {
            modelo.Cliente.Add(cliente);
            modelo.SaveChanges();
        }

        public List<Cliente> Listar()
        {
            return modelo.Cliente.ToList();
        }

        public List<Cliente> Buscar(string cliente)
        {
            return modelo.Cliente.Where(x => x.Apellido.Contains(cliente) || x.Nombre.Contains(cliente)).ToList();
        }

        public void Eliminar(int id)
        {
            var cliente = modelo.Cliente.First(x => x.ClienteId == id);
            modelo.Cliente.Remove(cliente);
            modelo.SaveChanges();
        }

        internal void Modificar(Cliente cliente)
        {
            var clienteParaModificar = modelo.Cliente.First(x => x.ClienteId == cliente.ClienteId);

            clienteParaModificar.Apellido = cliente.Apellido;
            clienteParaModificar.Nombre = cliente.Nombre;
            clienteParaModificar.Edad = cliente.Edad;

            modelo.SaveChanges();
        }

        public Cliente BuscarPorId(int id)
        {
            return modelo.Cliente.First(x => x.ClienteId == id);
        }

        public void Eliminar(string apellido, string Nombre)
        {
            var cliente = modelo.Cliente.Where(x => x.Apellido == apellido && x.Nombre == Nombre).First();
            modelo.Cliente.Remove(cliente);
            modelo.SaveChanges();
        }
    }
}