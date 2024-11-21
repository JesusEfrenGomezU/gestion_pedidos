using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IUsuariosRepositorio
    {
        void Configurar(string string_conexion);
        List<Usuarios> Listar();
        List<Usuarios> Buscar(Expression<Func<Usuarios, bool>> condiciones);
        Usuarios Guardar(Usuarios entidad);

        Usuarios Modificar(Usuarios entidad);

        Usuarios Borrar(Usuarios entidad);

        bool Existe(Expression<Func<Usuarios, bool>> condiciones);
    }
}
