using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IMensajerosPresentacion
    {
        Task<List<Mensajeros>> Listar();
        Task<List<Mensajeros>> Buscar(Mensajeros entidad, string tipo);
        Task<Mensajeros> Guardar(Mensajeros entidad);
        Task<Mensajeros> Modificar(Mensajeros entidad);
        Task<Mensajeros> Borrar(Mensajeros entidad);
    }
}