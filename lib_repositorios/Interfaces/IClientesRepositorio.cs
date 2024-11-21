using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IClientesRepositorio
    {
        void Configurar(string string_conexion);
        List<Clientes> Listar();
        List<Clientes> Buscar(Expression<Func<Clientes, bool>> condiciones);
        Clientes Guardar(Clientes entidad);

        Clientes Modificar(Clientes entidad);

        Clientes Borrar(Clientes entidad);

        bool Existe(Expression<Func<Clientes, bool>> condiciones);
    }
}
