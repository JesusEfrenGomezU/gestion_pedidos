using lib_repositorios.Implementaciones;
using lib_aplicaciones.Implementaciones;
using lib_aplicaciones.Interfaces;
using lib_repositorios;
using Microsoft.AspNetCore.Mvc;
using mst_pruebas.Nucleo;
using lib_entidades;
using Microsoft.EntityFrameworkCore;
using lib_repositorios.Interfaces;

namespace asp_servicios.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FacturasController : ControllerBase
    {
        private IFacturasAplicacion? IAplicacion = null;
        public FacturasController()
        {
            Conexion? conexion = new Conexion();
            conexion!.StringConnection = ConfiguracionHelper.ObtenerValor("ConectionString");
            IAplicacion = new FacturasAplicacion(
                new FacturasRepositorio(conexion));
        }
        
        [HttpGet]
        public IEnumerable<Facturas> Get()
        {
            var lista = IAplicacion!.Listar();
            return lista.ToArray();
            //Conexion? conexion = new Conexion();
            //conexion!.StringConnection = ConfiguracionHelper.ObtenerValor("ConectionString");
            //Facturas? entidad = EntidadesHelper.ObtenerFacturas();
            //conexion.Guardar(entidad!);
            //conexion.GuardarCambios();
            //return conexion.Listar<Facturas>();
            
        }
    }
}