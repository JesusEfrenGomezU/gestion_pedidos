﻿
using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Mensajeros
    {
        public int id = 0;
        public string transportista = "";

        [Key] public int Id { get => id; set => id = value; }
        public string Transportista { get => transportista; set => transportista = value; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(this.transportista) ||
                this.id <= 0)
                return false;
            return true;
        }
    }
}
