using lib_aplicaciones.Interfaces;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Implementaciones
{
    public class FacturasAplicacion : IFacturasAplicacion
    {
        private IFacturasRepositorio? iRepositorio = null;

        public FacturasAplicacion(IFacturasRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Facturas Borrar(Facturas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id_fac == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Facturas Guardar(Facturas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id_fac != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Facturas> Listar()
        {
            return iRepositorio!.Listar();
        }

        public List<Facturas> Buscar(Facturas entidad, string tipo)
        {
            Expression<Func<Facturas, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                case "cliente": condiciones = x => x.cliente!.Contains(entidad.cliente!); break;
                default: condiciones = x => x.id_fac == entidad.id_fac; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }

        public Facturas Modificar(Facturas entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id_fac == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
    }
}
