using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Pasillos : Lados, ICliente
    {
        // datos del pasillo
        // herededa de la clase lados para saber a que lado pertenece dentoro del deposito
        // tambien hereda de la interfaz cliente para saber si todo ese pasillo pertenece a un solo cliente 
    }
}
