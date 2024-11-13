
using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Mensajeros
    {
        private int id = 0;
        private string transportista = "";

        [Key] public int Id { get => id; set => id = value; }
        public string Transportista { get => transportista; set => transportista = value; }
    }
}
