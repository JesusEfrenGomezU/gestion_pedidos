
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades
{
    public class Detalles
    {
        private int id = 0;
        private Productos? producto = null;
        private Pedidos? pedido = null;

        [Key]public int Id { get => this.id; set => this.id = value; }
        //o NotMapped
        [ForeignKey("Producto_id")][Column("producto_id")] public Productos? Producto { get => this.producto; set => this.producto = value; }
        [ForeignKey("Pedido_id")][Column("pedido_id")] public Pedidos? Pedido { get => this.pedido; set => this.pedido = value; }
    }

}
