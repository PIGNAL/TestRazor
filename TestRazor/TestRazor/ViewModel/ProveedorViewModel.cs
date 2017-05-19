using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TestRazor.ViewModel
{
    public class ProveedorViewModel
    {

        [HiddenInput(DisplayValue =false)]
        public int? ProveedorId { get; set; }
        [Required][MaxLength(100)]
        public string Nombre { get; set; }
        [Required]
        public string Direccion { get; set; }
        [Required]
        public string Telefono { get; set; }
    }
}