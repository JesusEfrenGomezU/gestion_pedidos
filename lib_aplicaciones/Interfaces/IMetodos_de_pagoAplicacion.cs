using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IMetodos_de_pagoAplicacion
    {
        void Configurar(string string_conexion);
        List<Metodos_de_pago> Buscar(Metodos_de_pago entidad, string tipo);
        List<Metodos_de_pago> Listar();
        Metodos_de_pago Guardar(Metodos_de_pago entidad);
        Metodos_de_pago Modificar(Metodos_de_pago entidad);
        Metodos_de_pago Borrar(Metodos_de_pago entidad);
    }
}