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
    public class AuditoriasRepositorio : IAuditoriasRepositorio
    {
        private Conexion? conexion;

        public AuditoriasRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Auditorias> Listar()
        {
            return conexion!.Listar<Auditorias>();
        }

        public Auditorias Guardar(Auditorias entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public List<Auditorias> Buscar(Expression<Func<Auditorias, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Auditorias Modificar(Auditorias entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Auditorias Borrar(Auditorias entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Auditorias, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}
