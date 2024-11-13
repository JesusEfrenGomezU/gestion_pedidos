using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IMetodos_de_pago
    {
        void Configurar(string string_conexion);
        List<Metodos_de_pago> Listar();
        List<Metodos_de_pago> Buscar(Expression<Func<Metodos_de_pago, bool>> condiciones);
        Metodos_de_pago Guardar(Metodos_de_pago entidad);

        Metodos_de_pago Modificar(Metodos_de_pago entidad);

        Metodos_de_pago Borrar(Metodos_de_pago entidad);

        bool Existe(Expression<Func<Metodos_de_pago, bool>> condiciones);

    }
}
