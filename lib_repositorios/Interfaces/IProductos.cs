using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IProductos
    {
        void Configurar(string string_conexion);
        List<Productos> Listar();
        List<Productos> Buscar(Expression<Func<Productos, bool>> condiciones);
        Productos Guardar(Productos entidad);

        Productos Modificar(Productos entidad);

        Productos Borrar(Productos entidad);

        bool Existe(Expression<Func<Productos, bool>> condiciones);
    }
}
