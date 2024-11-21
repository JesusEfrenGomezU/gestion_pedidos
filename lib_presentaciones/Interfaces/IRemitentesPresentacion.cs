using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IRemitentesPresentacion
    {
        Task<List<Remitentes>> Listar();
        Task<List<Remitentes>> Buscar(Remitentes entidad, string tipo);
        Task<Remitentes> Guardar(Remitentes entidad);
        Task<Remitentes> Modificar(Remitentes entidad);
        Task<Remitentes> Borrar(Remitentes entidad);
    }
}