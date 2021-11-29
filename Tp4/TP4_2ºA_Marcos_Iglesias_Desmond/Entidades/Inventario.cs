using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Inventario
    {

        public abstract List<Producto> MiInventario { get; set; }
        public abstract List<Ticket> Historial_de_venta { get; set; }

        
    }
}
