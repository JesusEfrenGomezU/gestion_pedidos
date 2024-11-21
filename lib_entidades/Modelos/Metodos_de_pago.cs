
using System.ComponentModel.DataAnnotations;

namespace lib_entidades.Modelos
{
    public class Metodos_de_pago

    {

        private int id_pag = 0;
        private string tipo = "";

        [Key] public int Id_pag { get => id_pag; set => id_pag = value; }
        public string Tipo { get => tipo; set => tipo = value; }

        public bool Validar()
        {
            if (this.id_pag <= 0 ||
                string.IsNullOrEmpty(Tipo))
                return false;
            return true;
        }
    }
}
