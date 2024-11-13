using lib_aplicaciones.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_repositorios.Interfaces;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Implementaciones
{
    public class FacturasAplicacion : IFacturasAplicacion
    {
        private IFacturasAplicacion? iRepositorio = null;
        public FacturasAplicacion(IFacturas iRepositorio)
        {
            //(IFacturasAplicacion?) esta bien? sin eso me saca error
            this.iRepositorio = (IFacturasAplicacion?)iRepositorio;
        }
        public List<Facturas> Listar()
        {
            return iRepositorio!.Listar();
        }
    }
}
