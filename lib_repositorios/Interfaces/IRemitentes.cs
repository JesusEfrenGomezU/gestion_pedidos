using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IRemitentes
    {
        void Configurar(string string_conexion);
        List<Remitentes> Listar();
        List<Remitentes> Buscar(Expression<Func<Remitentes, bool>> condiciones);
        Remitentes Guardar(Remitentes entidad);

        Remitentes Modificar(Remitentes entidad);

        Remitentes Borrar(Remitentes entidad);

        bool Existe(Expression<Func<Remitentes, bool>> condiciones);
    }
}
