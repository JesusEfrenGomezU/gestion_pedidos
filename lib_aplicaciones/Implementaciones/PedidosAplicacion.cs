using lib_aplicaciones.Interfaces;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Implementaciones
{
    public class PedidosAplicacion : IPedidosAplicacion
    {
        private IPedidosRepositorio? iRepositorio = null;

        public PedidosAplicacion(IPedidosRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Pedidos Borrar(Pedidos entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id_fac == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Pedidos Guardar(Pedidos entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id_fac != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Pedidos> Listar()
        {
            return iRepositorio!.Listar();
        }

        public List<Pedidos> Buscar(Pedidos entidad, string tipo)
        {
            Expression<Func<Pedidos, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                case "cliente": condiciones = x => id_fac; break;
                default: condiciones = x => x.id_fac == entidad.id_fac; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }

        public Pedidos Modificar(Pedidos entidad)
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
