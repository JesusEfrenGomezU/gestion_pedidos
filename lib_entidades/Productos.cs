
using System.ComponentModel.DataAnnotations;

namespace lib_entidades
{
    public class Productos
    {

        private int id_prod = 0;
        private string nom_prod = "";
        private decimal precio = 0.0m;
        private int cantidad = 0;
        private decimal iva = 0.0m;

        [Key]public int Id_prod { get => this.id_prod; set => this.id_prod = value; }
        public int Cantidad { get => this.cantidad; set => this.cantidad = value; }
        public decimal Precio { get => this.precio; set => this.precio = value; }
        public decimal Iva { get => this.iva; set => this.iva = value; }
        public string Nom_prod { get => this.nom_prod; set => this.nom_prod = value; }

        public static void  ValidarIva()
        {
            
        }

        public static void ValidarPrecio() 
        { 
        
        }
    }
}
