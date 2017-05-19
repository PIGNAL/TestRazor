using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestRazor.Models.AccesoDatos;

namespace TestRazor.Models
{
    public class GestorProductos
    {
        RepositorioProductos repo = new RepositorioProductos();
        public void Guardar(Producto producto)
        {
            repo.Guardar(producto);
        }
        public List<Producto> Listar()
        {
            return repo.Listar();
        }
        public Producto Buscar(int id)
        {
            return repo.Buscar(id);
        }
        public void Eliminar(int id)
        {
            repo.Eliminar(id);
        }
        public void Modificar(Producto producto)
        {
            repo.Modificar(producto);
        }
        public List<Producto> BuscarProductos(string producto)
        {
            return repo.BuscarProductos(producto);
        }
        public void Eliminar(string codigo)
        {
            repo.Eliminar(codigo);
        }
    }
}