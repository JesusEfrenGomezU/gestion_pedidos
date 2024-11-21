using lib_aplicaciones.Interfaces;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Implementaciones
{
    public class ProductosAplicacion : IProductosAplicacion
    {
        private IProductosRepositorio? iRepositorio = null;

        public ProductosAplicacion(IProductosRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Productos Borrar(Productos entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id_prod == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Productos Guardar(Productos entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id_prod != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Productos> Listar()
        {
            return iRepositorio!.Listar();
        }

        public List<Productos> Buscar(Productos entidad, string tipo)
        {
            Expression<Func<Productos, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                case "Producto": condiciones = x => x.nom_prod!.Contains(entidad.nom_prod!); break;
                default: condiciones = x => x.id_prod == entidad.id_prod; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }

        public Productos Modificar(Productos entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id_prod == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
    }
}
