using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestRazor.Models.AccesoDatos;

namespace TestRazor.Models
{
    public class GestorProveedores
    {
        RepositorioProveedores repo = new RepositorioProveedores();
        public void Guardar(Proveedor proveedor)
        {
            repo.Guardar(proveedor);
        }
        public List<Proveedor> Listar()
        {
            return repo.Listar();
        }
        public Proveedor Buscar(int id)
        {
            return repo.Buscar(id);
        }
        public void Eliminar(int id)
        {
            repo.Eliminar(id);
        }
        public void Modificar(Proveedor proveedor)
        {
            repo.Modificar(proveedor);
        }
        public List<Proveedor> BuscarProveedores(string proveedor)
        {
            return repo.BuscarProvedores(proveedor);
        }
        public void Eliminar(string nombre)
        {
            repo.Eliminar(nombre);
        }
    }
}