using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestRazor.Models
{
    public class Persona
    {
        public string Apellido { get; set; }

        public string ApellidoDeSoltera { get; set; }

        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string Email { get; set; }
    }
}