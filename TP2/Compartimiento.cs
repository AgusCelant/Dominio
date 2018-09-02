using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Compartimiento : Pasillos, ICliente  
    {
        //datos del copartimiento
        //hereda datos de la clase pasillos para saber a cual pertenece
        // tambien hereda de la interface cliente para saber si todo ese comparimiento pertenece al mismo cliente 
    }
}
