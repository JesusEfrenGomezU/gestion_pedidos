
using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Remitentes
    {
        private int id = 0;
        private string nombre = "";
        private string direcc_rem = "";

        [Key]public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string Direcc_rem { get => this.direcc_rem; set => this.direcc_rem = value; }

        public bool Validar()
        {   if (string.IsNullOrEmpty(nombre) ||
                this.id <= 0 ||
                string.IsNullOrEmpty(direcc_rem))
                return false;
            return true;
        }
    }
}
