
using System.ComponentModel.DataAnnotations;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_entidades.Modelos
{
    public class Remitentes
    {
        private int id = 0;
        private string nombre = "";
        private string direcc_rem = "";

        [Key] public int Id { get => this.id; set => this.id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direcc_rem { get => direcc_rem; set => direcc_rem = value; }
    }
}
