
using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Clientes
    {

        public int id = 0;
        public string cedula = "";
        public string nombre = "";
        public string telefono = "";
        public string direcc = "";

        [Key] public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direcc { get => direcc; set => direcc = value; }

        public bool Validar()
        {
            if (this.id <= 0 ||
               string.IsNullOrEmpty(nombre) ||
               string.IsNullOrEmpty(cedula) ||
               string.IsNullOrEmpty(telefono) ||
               string.IsNullOrEmpty(direcc))
                return false;
            return true;
        }

    }
}
