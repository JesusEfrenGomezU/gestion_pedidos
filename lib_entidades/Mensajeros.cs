
using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Mensajeros
    {
        private int id = 0;
        private string transportista = "";

        [Key]public int Id { get => this.id; set => this.id = value; }
        public string Transportista { get => this.transportista; set => this.transportista = value; }
    }
}
