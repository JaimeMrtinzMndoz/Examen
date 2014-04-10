using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolaMundoMVC.Models
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public DateTime FechaAlta { get; set; }
    }
}