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
        private Roles rol = null;
        private string password = "";
        [Key] public int Id { get => this.id; set => this.id = value; }
        public string? Usuario { get => this.usuario; set => this.usuario = value; }
        public Roles? Rol { get => this.rol; set => this.rol = value; }
        public string? Password { get => this.password; set => this.password = value; }
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
