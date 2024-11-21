using lib_aplicaciones.Interfaces;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Implementaciones
{
    public class RemitentesAplicacion : IRemitentesAplicacion
    {
        private IRemitentesRepositorio? iRepositorio = null;

        public RemitentesAplicacion(IRemitentesRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Remitentes Borrar(Remitentes entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id_fac == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Remitentes Guardar(Remitentes entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id_fac != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Remitentes> Listar()
        {
            return iRepositorio!.Listar();
        }

        public List<Remitentes> Buscar(Remitentes entidad, string tipo)
        {
            Expression<Func<Remitentes, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                case "cliente": condiciones = x => id_fac; break;
                default: condiciones = x => x.id_fac == entidad.id_fac; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }

        public Remitentes Modificar(Remitentes entidad)
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
