using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Producto : Compartimiento, ICliente 
    {
        // DATOS DEL PRODUCTO
        //hereda datos de la interface Cliente para saber a quien pertenece
        // tambien hereda datos del compartimiento al cual pertenece
    }
}
