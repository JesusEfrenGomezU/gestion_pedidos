using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IFacturasAplicacion
    {
        List<Facturas> Listar();
        //Facturas Guardar(Facturas entidad);
        //Facturas Modificar(Facturas entidad);
        //Facturas Borrar(Facturas entidad);
    }
}
