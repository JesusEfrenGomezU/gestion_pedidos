using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace lib_entidades
{
    public class Facturas
    {
        private int id_fac = 0;
        private Clientes cliente = null;
        private DateTime fecha;
        private Metodos_de_pago m_pago = null;
        private decimal iva = 0.0m;
        private decimal total = 0.0m;
        private Detalles details = null;
        private Remitentes remi = null;
        private Mensajeros menj = null;

        public Facturas()
        {

        }

        [Key] public int Id_fac { get => this.id_fac; set => this.id_fac = value; }
        public decimal Iva { get => this.iva; set => this.iva = value; }
        public decimal Total { get => this.total; set => this.total = value; }


        [ForeignKey("Cliente_id")][Column("cliente_id")]public Clientes? Cliente { get => this.cliente; set => this.cliente = value; }
        public DateTime Fecha { get => this.fecha; set => this.fecha = value; }
        [ForeignKey("M_pago_id")][Column("m_pago_id")] public Metodos_de_pago? M_pago { get => this.m_pago; set => this.m_pago = value; }
        [ForeignKey("Detalle_id")][Column("detalle_id")] public Detalles? Details { get => this.details; set => this.details = value; }
        [ForeignKey("Remitente_id")][Column("remitente_id")] public Remitentes? Remi { get => this.remi; set => this.remi = value; }
        [ForeignKey("Mensajero_id")][Column("mensajero_id")] public Mensajeros Menj { get => this.menj; set => this.menj = value; }

        public static void administrarDetalles()
        {

        }

        public static void validarEstado()
        {

        }

        public static void validarFactura()
        {

        }

    }
}
