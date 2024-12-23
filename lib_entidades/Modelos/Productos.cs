﻿
using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Productos
    {

        public int id_prod = 0;
        public string nom_prod = "";
        public decimal precio = 0.0m;
        public int cantidad = 0;
        public decimal iva = 0.0m;

        [Key] public int Id_prod { get => id_prod; set => id_prod = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public decimal Precio { get => precio; set => precio = value; }
        public decimal Iva { get => iva; set => iva = value; }
        public string Nom_prod { get => nom_prod; set => nom_prod = value; }

        public bool Validar()
        {
            if (this.id_prod <= 0 ||
                this.precio <= 0 ||
                string.IsNullOrEmpty(Nom_prod) ||
                this.cantidad <= 0 ||
                this.iva <= 0)
                return false;
            return true;
        }
        public static void ValidarIva()
        {

        }

        public static void ValidarPrecio()
        {

        }
    }
}
