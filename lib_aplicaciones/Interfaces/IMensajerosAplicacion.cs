using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IMensajerosAplicacion
    {
        void Configurar(string string_conexion);
        List<Mensajeros> Buscar(Mensajeros entidad, string tipo);
        List<Mensajeros> Listar();
        Mensajeros Guardar(Mensajeros entidad);
        Mensajeros Modificar(Mensajeros entidad);
        Mensajeros Borrar(Mensajeros entidad);
    }
}