using lib_entidades;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class RemitentesRepositorio : IRemitentes
    {
        private Conexion? conexion;

        public RemitentesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }
        public List<Remitentes> Listar()
        {
            return conexion!.Listar<Remitentes>();
        }

        public Remitentes Guardar(Remitentes entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public List<Remitentes> Buscar(Expression<Func<Remitentes, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Remitentes Modificar(Remitentes entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Remitentes Borrar(Remitentes entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Remitentes, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }


    }
}
