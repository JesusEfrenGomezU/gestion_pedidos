using lib_aplicaciones.Interfaces;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Implementaciones
{
    public class UsuariosAplicacion : IUsuariosAplicacion
    {
        private IUsuariosRepositorio? iRepositorio = null;

        public UsuariosAplicacion(IUsuariosRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Usuarios Borrar(Usuarios entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Usuarios Guardar(Usuarios entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Usuarios> Listar()
        {
            return iRepositorio!.Listar();
        }

        public List<Usuarios> Buscar(Usuarios entidad, string tipo)
        {
            Expression<Func<Usuarios, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                case "usuario": condiciones = x => x.usuario!.Contains(entidad.usuario!); break;
                default: condiciones = x => x.id == entidad.id; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }

        public Usuarios Modificar(Usuarios entidad)
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
