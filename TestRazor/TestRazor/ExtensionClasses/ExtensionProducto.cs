using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRazor.ExtensionClasses
{
    public static class ExtensionProducto
    {
        public static Models.Producto ConvertirAModelo(this ViewModel.ProductoViewModel productoViewModel)
        {
            var producto = new Models.Producto
            {
                Nombre = productoViewModel.Nombre,
                Precio = productoViewModel.Precio,
                Codigo = productoViewModel.Codigo,
                Stock = productoViewModel.Stock
            };
            return producto;
        }
        public static List<ViewModel.ProductoViewModel> ConvertirAViewModel(this List<Models.Producto> productos)
        {
            var listaDeViewModel = new List<ViewModel.ProductoViewModel>();

            foreach (var productoDelModelo in productos)
            {
                var productoViewModel = new ViewModel.ProductoViewModel
                {
                    Nombre = productoDelModelo.Nombre,
                    Precio = productoDelModelo.Precio,
                    Codigo = productoDelModelo.Codigo,
                    Stock = productoDelModelo.Stock,
                    ProductoId = productoDelModelo.ProductoId
                };
                listaDeViewModel.Add(productoViewModel);
            }
            return listaDeViewModel;
        }
        public static ViewModel.ProductoViewModel ConvertirAViewModel(this Models.Producto productoModelo)
        {
            var productoViewModel = new ViewModel.ProductoViewModel
            {
                Nombre = productoModelo.Nombre,
                Precio = productoModelo.Precio,
                Codigo = productoModelo.Codigo,
                Stock = productoModelo.Stock,
                ProductoId = productoModelo.ProductoId
            };
            return productoViewModel;
        }
        public static string ConvertirAString(this Models.Producto productoModelo)
        {
            var producto = productoModelo.Nombre + " " + 
                           productoModelo.Precio + " " + 
                           productoModelo.Codigo + " " + 
                           productoModelo.Stock;
            return producto;
        }
    }
}