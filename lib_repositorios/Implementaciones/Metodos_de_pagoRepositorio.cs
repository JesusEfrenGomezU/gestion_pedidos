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
    public class Metodos_de_pagoRepositorio : IMetodos_de_pago
    {
        private Conexion? conexion;

        public Metodos_de_pagoRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Metodos_de_pago> Listar()
        {
            return conexion!.Listar<Metodos_de_pago>();
        }

        public Metodos_de_pago Guardar(Metodos_de_pago entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public List<Metodos_de_pago> Buscar(Expression<Func<Metodos_de_pago, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Metodos_de_pago Modificar(Metodos_de_pago entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public Metodos_de_pago Borrar(Metodos_de_pago entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            conexion!.Separadar(entidad);
            return entidad;
        }

        public bool Existe(Expression<Func<Metodos_de_pago, bool>> condiciones)
        {
            return conexion!.Existe(condiciones);
        }
    }
}
