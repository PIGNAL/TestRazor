using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRazor.ExtensionClasses
{
    public static class ExtencionProvedor
    {
        public static Models.Proveedor ConvertirAModelo(this ViewModel.ProveedorViewModel proveedorViewModel)
        {
            var proveedor = new Models.Proveedor
            {
                Nombre = proveedorViewModel.Nombre,
                Direccion = proveedorViewModel.Direccion,
                Telefono = proveedorViewModel.Telefono
            };
            return proveedor;
        }
        public static List<ViewModel.ProveedorViewModel> ConvertirAViewModel(this List<Models.Proveedor> proveedores)
        {
            var listaDeViewModel = new List<ViewModel.ProveedorViewModel>();
            foreach (var proveedorDelModelo in proveedores)
            {
                var proveedorViewModel = new ViewModel.ProveedorViewModel
                {
                    ProveedorId = proveedorDelModelo.ProveedorId,
                    Nombre = proveedorDelModelo.Nombre,
                    Telefono = proveedorDelModelo.Telefono,
                    Direccion = proveedorDelModelo.Direccion
                };
                listaDeViewModel.Add(proveedorViewModel);
            }
            return listaDeViewModel;
        }
        public static ViewModel.ProveedorViewModel ConvertirModelAViewModel(this Models.Proveedor proveedorModelo)
        {
            var proveedorViewModel = new ViewModel.ProveedorViewModel
            {
                ProveedorId = proveedorModelo.ProveedorId,
                Direccion = proveedorModelo.Direccion,
                Nombre = proveedorModelo.Nombre,
                Telefono = proveedorModelo.Telefono
            };
            return proveedorViewModel;   
        }
    }
}