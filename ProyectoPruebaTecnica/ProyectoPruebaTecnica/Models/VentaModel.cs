using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoPruebaTecnica.Models
{

    public class VentaModel
    {
        public List<ProductoModel> Productos { get; set; }
        public int IdCliente { get; set; }
    }
}