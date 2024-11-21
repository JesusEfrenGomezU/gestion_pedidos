using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace lib_entidades.Modelos
{
    public class Usuarios
    {
        public int id = 0;
        public string usuario = "";
        public string password = "";
        [Key] public int Id { get => this.id; set => this.id = value; }
        public string? Usuario { get => this.usuario; set => this.usuario = value; }
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
