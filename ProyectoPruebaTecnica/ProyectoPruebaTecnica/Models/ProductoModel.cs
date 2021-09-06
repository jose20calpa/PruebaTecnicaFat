using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPruebaTecnica.Models
{
    public class ProductoModel
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public float Precio{ get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }
}