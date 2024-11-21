using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IRolesRepositorio
    {
        void Configurar(string string_conexion);
        List<Roles> Listar();
        List<Roles> Buscar(Expression<Func<Roles, bool>> condiciones);
        Roles Guardar(Roles entidad);

        Roles Modificar(Roles entidad);

        Roles Borrar(Roles entidad);

        bool Existe(Expression<Func<Roles, bool>> condiciones);
    }
}
