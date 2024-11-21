using lib_aplicaciones.Interfaces;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Implementaciones
{
    public class MensajerosAplicacion : IMensajerosAplicacion
    {
        private IMensajerosRepositorio? iRepositorio = null;

        public MensajerosAplicacion(IMensajerosRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Mensajeros Borrar(Mensajeros entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Mensajeros Guardar(Mensajeros entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Mensajeros> Listar()
        {
            return iRepositorio!.Listar();
        }

        public List<Mensajeros> Buscar(Mensajeros entidad, string tipo)
        {
            Expression<Func<Mensajeros, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                case "transportista": condiciones = x => x.transportista!.Contains(entidad.transportista!); break;
                default: condiciones = x => x.id == entidad.id; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }

        public Mensajeros Modificar(Mensajeros entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
    }
}
