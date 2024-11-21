using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IAuditoriasRepositorio
    {
        void Configurar(string string_conexion);
        List<Auditorias> Listar();
        List<Auditorias> Buscar(Expression<Func<Auditorias, bool>> condiciones);
        Auditorias Guardar(Auditorias entidad);

        Auditorias Modificar(Auditorias entidad);

        Auditorias Borrar(Auditorias entidad);

        bool Existe(Expression<Func<Auditorias, bool>> condiciones);
    }
}
