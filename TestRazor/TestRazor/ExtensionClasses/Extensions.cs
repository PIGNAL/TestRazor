using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRazor.ExtensionClasses
{
    public static class Extensions
    {
        public static Models.Cliente ConvertirAModelo(this ViewModel.Cliente clienteViewModel)
        {
            var cliente = new Models.Cliente
            {
                Apellido = clienteViewModel.Apellido,
                Nombre = clienteViewModel.Nombre,
                Edad = clienteViewModel.Edad
            };
            return cliente;
        }

        public static List<ViewModel.Cliente> ConvertirAViewModel(this List<Models.Cliente> clientes)
        {
            var listaDeViewModel = new List<ViewModel.Cliente>();

            foreach (var clienteDelModelo in clientes)
            {
                var clienteViewModel = new ViewModel.Cliente
                {
                    ClienteId = clienteDelModelo.ClienteId,
                    Apellido = clienteDelModelo.Apellido,
                    Nombre = clienteDelModelo.Nombre,
                };
                listaDeViewModel.Add(clienteViewModel);
            }
            return listaDeViewModel;
        }

        public static ViewModel.Cliente ConvertirAViewModel(this Models.Cliente clienteModelo)
        {

            var clienteViewModel = new ViewModel.Cliente
            {
                Apellido = clienteModelo.Apellido,
                Nombre = clienteModelo.Nombre,
                Edad = clienteModelo.Edad,
                ClienteId = clienteModelo.ClienteId
            };
            return clienteViewModel;
        }

        public static string ConvertirAString(this Models.Cliente clienteModelo)
        {
            var cliente = clienteModelo.Apellido + " " + clienteModelo.Nombre + " " + clienteModelo.Edad;
            return cliente;
        }
    }
}