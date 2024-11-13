using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class MensajerosRepositorio : IMensajeros
    {
        private Conexion? conexion;
        public MensajerosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }
        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Mensajeros> Listar()
        {
            return conexion!.Listar<Mensajeros>();
        }
        public Mensajeros Guardar(Mensajeros entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public List<Mensajeros> Buscar(Expression<Func<Mensajeros, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Mensajeros Modificar(Mensajeros entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Mensajeros Borrar(Mensajeros entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Mensajeros, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }

    }
}
