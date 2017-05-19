using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TestRazor.Common;

namespace TestRazor.Models.AccesoDatos
{
    public class RepositorioProveedores
    {
        TestRazorEntities modelo = new TestRazorEntities();

        public RepositorioProveedores()
        {
            modelo.Database.Log = Logger.Log;
        }
        public void Guardar(Proveedor proveedor)
        {
            modelo.Proveedor.Add(proveedor);
            modelo.SaveChanges();
        }
        public List<Proveedor> Listar()
        {
            return modelo.Proveedor.ToList();
        }
        public Proveedor Buscar(int id)
        {
            return modelo.Proveedor.Where(x => x.ProveedorId == id).FirstOrDefault();
        }
        public void Eliminar(int id)
        {
            var proveedor = modelo.Proveedor.First(x => x.ProveedorId == id);
            modelo.Proveedor.Remove(proveedor);
            modelo.SaveChanges();
        }
        public void Modificar(Proveedor proveedor)
        {
            var proveedorParaModificar = modelo.Proveedor.First(x => x.ProveedorId == proveedor.ProveedorId);
            proveedorParaModificar.Nombre = proveedor.Nombre;
            proveedorParaModificar.Telefono = proveedor.Telefono;
            proveedorParaModificar.Direccion = proveedor.Direccion;
            modelo.SaveChanges();
        }
        public List<Proveedor> BuscarProvedores(string proveedor)
        {
            return modelo.Proveedor.Where(x => x.Nombre.Contains(proveedor) || x.Telefono.ToString().Contains(proveedor)).ToList();
        }
        public void Eliminar(string nombre)
        {
            var producto = modelo.Proveedor.FirstOrDefault(x => x.Nombre == nombre);
            modelo.Proveedor.Remove(producto);
            modelo.SaveChanges();
        }
    }
}
