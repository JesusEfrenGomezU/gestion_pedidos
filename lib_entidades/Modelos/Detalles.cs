﻿
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Detalles
    {
        private int id = 0;
        private Productos? producto = null;
        private Pedidos? pedido = null;

        [Key] public int Id { get => id; set => id = value; }
        //o NotMapped
        [ForeignKey("Producto_id")][Column("producto_id")] public Productos? Producto { get => producto; set => producto = value; }
        [ForeignKey("Pedido_id")][Column("pedido_id")] public Pedidos? Pedido { get => pedido; set => pedido = value; }
    }

}
