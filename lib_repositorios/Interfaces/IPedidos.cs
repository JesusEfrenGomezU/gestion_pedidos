using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IPedidos
    {
        void Configurar(string string_conexion);
        List<Pedidos> Listar();
        List<Pedidos> Buscar(Expression<Func<Pedidos, bool>> condiciones);
        Pedidos Guardar(Pedidos entidad);

        Pedidos Modificar(Pedidos entidad);

        Pedidos Borrar(Pedidos entidad);

        bool Existe(Expression<Func<Pedidos, bool>> condiciones);

    }
}
