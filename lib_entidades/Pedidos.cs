
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Pedidos
    {
        private int id = 0;
        private int cod_pedido = 0;
        private string descripcion = "";
        private string medidas = "";
        private string estado = "";
        private Remitentes remi = null;


        [Key]public int Id { get => this.id; set => this.id = value; }
        public int Cod_pedido { get => this.cod_pedido; set => this.cod_pedido = value; }
        public string Descripcion { get => this.descripcion; set => this.descripcion = value; }
        public string Medidas { get => this.medidas; set => this.medidas = value; }
        public string Estado { get => this.estado; set => this.estado = value; }
        [ForeignKey("Remitente_id")][Column("remitente_id")] public Remitentes? Remi { get => this.remi; set => this.remi = value; }
    }
}
