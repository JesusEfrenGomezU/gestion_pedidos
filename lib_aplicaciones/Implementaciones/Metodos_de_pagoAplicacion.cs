using lib_aplicaciones.Interfaces;
using lib_repositorios.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;

namespace lib_aplicaciones.Implementaciones
{
    public class Metodos_de_pagoAplicacion : IMetodos_de_pagoAplicacion
    {
        private IMetodos_de_pagoRepositorio? iRepositorio = null;

        public Metodos_de_pagoAplicacion(IMetodos_de_pagoRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Metodos_de_pago Borrar(Metodos_de_pago entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id_fac == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Metodos_de_pago Guardar(Metodos_de_pago entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.id_fac != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Metodos_de_pago> Listar()
        {
            return iRepositorio!.Listar();
        }

        public List<Metodos_de_pago> Buscar(Metodos_de_pago entidad, string tipo)
        {
            Expression<Func<Metodos_de_pago, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                case "cliente": condiciones = x => id_fac; break;
                default: condiciones = x => x.id_fac == entidad.id_fac; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }

        public Metodos_de_pago Modificar(Metodos_de_pago entidad)
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
