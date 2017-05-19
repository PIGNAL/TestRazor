using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestRazor.Common;

namespace TestRazor.Models.AccesoDatos
{
    public class RepositorioProductos
    {
        TestRazorEntities modelo = new TestRazorEntities();

        public RepositorioProductos()
        {
            modelo.Database.Log = Logger.Log;
        }
        public void Guardar(Producto producto)
        {
            modelo.Producto.Add(producto);
            modelo.SaveChanges();
        }
        public List<Producto>Listar()
        {
            return modelo.Producto.ToList();
        }
        public Producto Buscar(int id)
        {
            return modelo.Producto.Where(x => x.ProductoId == id).FirstOrDefault();
        }
        public void Eliminar(int id)
        {
            var producto = modelo.Producto.First(x => x.ProductoId == id);
            modelo.Producto.Remove(producto);
            modelo.SaveChanges();
        }
        public void Modificar(Producto producto)
        {
            var productoParaModificar = modelo.Producto.First(x => x.ProductoId == producto.ProductoId);
            productoParaModificar.Nombre = producto.Nombre;
            productoParaModificar.Precio = producto.Precio;
            productoParaModificar.Codigo = producto.Codigo;
            productoParaModificar.Stock = producto.Stock;
            modelo.SaveChanges();
        }
        public List<Producto> BuscarProductos(string producto)
        {
            return modelo.Producto.Where(x => x.Nombre.Contains(producto) || x.Precio.ToString().Contains(producto)).ToList();
        }
        public void Eliminar(string codigo)
        {
            var producto = modelo.Producto.FirstOrDefault(x => x.Codigo == codigo);
            modelo.Producto.Remove(producto);
            modelo.SaveChanges();
        }
    }
}
