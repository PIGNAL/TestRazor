using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TestRazor.ViewModel
{
    public class Persona
    {
        [Required(ErrorMessage = "facha te olvidaste de poner el Apellido")]
        public string Apellido { get; set; }

        [DisplayName("Apellido de Soltera")]
        [Required]
        public string ApellidoDeSoltera { get; set; }

        [Required]
        [DisplayName("Nombre:")]
        [StringLength(maximumLength:10, ErrorMessage = "No deberías ingresar un v...", MinimumLength = 5)]
        public string Nombre { get; set; }

        [Required]
        [ValidarEdad]
        public int Edad { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.CreditCard)]
        public string test { get; set; }
    }
}