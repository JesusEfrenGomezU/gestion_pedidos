
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Pedidos
    {
        private int id = 0;
        private int cod_pedido = 0;
        private string descripcion = "";
        private string medidas = "";
        private string estado = "";
        private Remitentes remi = null;


        [Key] public int Id { get => id; set => id = value; }
        public int Cod_pedido { get => cod_pedido; set => cod_pedido = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Medidas { get => medidas; set => medidas = value; }
        public string Estado { get => estado; set => estado = value; }
        [ForeignKey("Remitente_id")][Column("remitente_id")] public Remitentes? Remi { get => remi; set => remi = value; }
    }
}
