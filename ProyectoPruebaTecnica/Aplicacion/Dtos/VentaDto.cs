using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.Dtos
{
    public class VentaDto
    {
        public List<ProductoDto> Productos { get; set; }
        public int IdCliente { get; set; }
    }
}
