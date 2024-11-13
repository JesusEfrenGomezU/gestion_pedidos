
using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Clientes
    {

        private int id = 0;
        private string cedula = "";
        private string nombre = "";
        private string telefono = "";
        private string direcc = "";

        [Key] public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Direcc { get => direcc; set => direcc = value; }

    }
}
