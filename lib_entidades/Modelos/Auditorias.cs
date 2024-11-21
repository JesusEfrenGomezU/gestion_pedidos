using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lib_entidades.Modelos
{
    public class Auditorias
    {
        private int id = 0;
        private string? tabla = "";
        private int referencia = 0;
        private string accion = "";

        public int Id { get => this.id; set => this.id = value; }
        public string? Tabla { get => this.Tabla; set => this.Tabla = value; }
        public int Referencia { get => this.Referencia; set => this.Referencia = value; }
        public string? Accion { get => this.Accion; set => this.Accion = value; }

        public bool Validar()
        {
            if (this.id <= 0 ||
                string.IsNullOrEmpty(Accion) ||
                string.IsNullOrEmpty(Tabla) ||
                this.referencia <= 0)
                return false;
            return true;
        }
    }
}
