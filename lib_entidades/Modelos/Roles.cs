using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace lib_entidades.Modelos
{
    public class Roles
    {
        public int id = 0;
        public string rol = "";
        [Key] public int Id { get => this.id; set => this.id = value; }
        public string? Rol { get => Rol; set => Rol = value; }
        public bool Validar()
        {
            if (this.id <= 0 ||
                string.IsNullOrEmpty(Rol))
                return false;
            return true;
        }
    }
}