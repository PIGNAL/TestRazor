using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TestRazor.ViewModel
{
    public class ProductoViewModel
    {
        [HiddenInput(DisplayValue =false)]
        public int? ProductoId { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public decimal Precio { get; set; }
        [Required]
        public string Codigo { get; set; }
        [Required]
        public int Stock { get; set; }
    }
}