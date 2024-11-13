
using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Productos
    {

        private int id_prod = 0;
        private string nom_prod = "";
        private decimal precio = 0.0m;
        private int cantidad = 0;
        private decimal iva = 0.0m;

        [Key] public int Id_prod { get => id_prod; set => id_prod = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public decimal Iva { get => iva; set => iva = value; }
        public string Nom_prod { get => nom_prod; set => nom_prod = value; }

        public static void ValidarIva()
        {

        }

        public static void ValidarPrecio()
        {

        }
    }
}
