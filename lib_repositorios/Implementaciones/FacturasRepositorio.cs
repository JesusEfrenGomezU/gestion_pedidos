using lib_entidades;
using lib_repositorios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Implementaciones
{
    public class FacturasRepositorio : IFacturas
    {
        private Conexion? conexion;

        public FacturasRepositorio(Conexion conexion) {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion) { 
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Facturas> Listar()
        {
            return conexion!.Listar<Facturas>();
        }

        public Facturas Guardar (Facturas entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public List<Facturas> Buscar(Expression<Func<Facturas, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Facturas Modificar(Facturas entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Facturas Borrar(Facturas entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Facturas, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}
