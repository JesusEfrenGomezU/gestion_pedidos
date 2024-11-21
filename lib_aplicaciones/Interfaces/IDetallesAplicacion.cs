using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IDetallesAplicacion
    {
        void Configurar(string string_conexion);
        List<Detalles> Buscar(Detalles entidad, string tipo);
        List<Detalles> Listar();
        Detalles Guardar(Detalles entidad);
        Detalles Modificar(Detalles entidad);
        Detalles Borrar(Detalles entidad);
    }
}