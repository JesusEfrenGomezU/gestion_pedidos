using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IFacturas
    {
        void Configurar(string string_conexion);
        List<Facturas> Listar();
        List<Facturas> Buscar(Expression<Func<Facturas, bool>> condiciones);
        Facturas Guardar(Facturas entidad);

        Facturas Modificar(Facturas entidad);

        Facturas Borrar(Facturas entidad);

        bool Existe(Expression<Func<Facturas, bool>> condiciones);
    }
}
