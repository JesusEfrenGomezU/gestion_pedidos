using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib_entidades.Modelos
{
    public class Usuarios
    {
        private int id = 0;
        private string usuario = "";
        private string password = "";

        [Key] public int Id { get => this.id; set => this.id = value; }
        private string? Usuario { get => this.usuario; set => this.usuario = value; }
        private string? Password { get => this.password; set => this.password = value; }

        public bool Validar()
        {
            if (this.id <= 0 ||
                string.IsNullOrEmpty(Usuario) ||
                string.IsNullOrEmpty(Password)) 
                return false;
            return true;
        }
    }
}
