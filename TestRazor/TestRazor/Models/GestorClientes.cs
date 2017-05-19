using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestRazor.Models.AccesoDatos;

namespace TestRazor.Models
{
    public class GestorClientes
    {
        RepositorioClientes repo = new RepositorioClientes();

        public void Guardar(Cliente cliente)
        {
            repo.guardar(cliente);
        }

        public List<Cliente> Listar()
        {
            return repo.Listar();
        }

        public List<Cliente> Buscar(string cliente)
        {
            return repo.Buscar(cliente);
        }

        public void Eliminar(int id)
        {
            repo.Eliminar(id);
        }

        public void Eliminar (string apellido, string nombre)
        {
            repo.Eliminar(apellido, nombre);
        }

        internal Cliente BuscarPorId(int id)
        {
            return repo.BuscarPorId(id);
        }

        public void Modificar(Cliente cliente)
        {
            repo.Modificar(cliente);
        }
    }
}