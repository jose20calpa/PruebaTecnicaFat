using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPruebaTecnica.Models
{
    public class ClienteModel
    {
        public int IdTipoDocumento{ get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}