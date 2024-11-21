
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Pedidos
    {
        public int id = 0;
        public int cod_pedido = 0;
        public string descripcion = "";
        public string medidas = "";
        public string estado = "";
        public Remitentes remi = null;


        [Key] public int Id { get => id; set => id = value; }
        public int Cod_pedido { get => cod_pedido; set => cod_pedido = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string Medidas { get => medidas; set => medidas = value; }
        public string Estado { get => estado; set => estado = value; }
        [ForeignKey("Remitente_id")][Column("remitente_id")] public Remitentes? Remi { get => remi; set => remi = value; }

        public bool Validar()
        {
            if (this.id <= 0 ||
                this.cod_pedido <= 0 ||
                string.IsNullOrEmpty(Descripcion) ||
                string.IsNullOrEmpty(Medidas) ||
                string.IsNullOrEmpty(Estado))
                return false;
            return true;
        }
    }
}
