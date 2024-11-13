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
    public class ClientesRepositorio : IClientes
    {
        private Conexion? conexion;

        public ClientesRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Clientes> Listar()
        {
            return conexion!.Listar<Clientes>();
        }

        public Clientes Guardar(Clientes entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public List<Clientes> Buscar(Expression<Func<Clientes, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Clientes Modificar(Clientes entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Clientes Borrar(Clientes entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Clientes, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}
