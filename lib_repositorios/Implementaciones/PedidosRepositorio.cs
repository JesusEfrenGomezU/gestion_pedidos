using lib_entidades.Modelos;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class PedidosRepositorio : IPedidos
    {
        private Conexion? conexion;

        public PedidosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Pedidos> Listar()
        {
            return conexion!.Listar<Pedidos>();
        }

        public Pedidos Guardar(Pedidos entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public List<Pedidos> Buscar(Expression<Func<Pedidos, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Pedidos Modificar(Pedidos entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Pedidos Borrar(Pedidos entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Pedidos, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}
