using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace lib_entidades.Modelos
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

        [Key] public int Id_fac { get => id_fac; set => id_fac = value; }
        public decimal Iva { get => iva; set => iva = value; }
        public decimal Total { get => total; set => total = value; }


        [ForeignKey("Cliente_id")][Column("cliente_id")] public Clientes? Cliente { get => cliente; set => cliente = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        [ForeignKey("M_pago_id")][Column("m_pago_id")] public Metodos_de_pago? M_pago { get => m_pago; set => m_pago = value; }
        [ForeignKey("Detalle_id")][Column("detalle_id")] public Detalles? Details { get => details; set => details = value; }
        [ForeignKey("Remitente_id")][Column("remitente_id")] public Remitentes? Remi { get => remi; set => remi = value; }
        [ForeignKey("Mensajero_id")][Column("mensajero_id")] public Mensajeros Menj { get => menj; set => menj = value; }

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
