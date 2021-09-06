using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Venta
    {
        public List<Producto> Productos { get; set; }
        public int IdCliente { get; set; }
    }
}
