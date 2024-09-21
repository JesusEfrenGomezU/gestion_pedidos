
using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Metodos_de_pago

    {

        private int id_pag = 0;
        private string tipo = "";

        [Key]public int Id_pag { get => this.id_pag; set => this.id_pag = value; }
        public string Tipo { get => this.tipo; set => this.tipo = value; }
    }
}
