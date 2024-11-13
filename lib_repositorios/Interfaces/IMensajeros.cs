using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IMensajeros
    {
        void Configurar(string string_conexion);
        List<Mensajeros> Listar();
        List<Mensajeros> Buscar(Expression<Func<Mensajeros, bool>> condiciones);
        Mensajeros Guardar(Mensajeros entidad);

        Mensajeros Modificar(Mensajeros entidad);

        Mensajeros Borrar(Mensajeros entidad);

        bool Existe(Expression<Func<Mensajeros, bool>> condiciones);

    }
}
