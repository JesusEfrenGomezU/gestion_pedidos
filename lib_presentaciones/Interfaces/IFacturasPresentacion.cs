using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IFacturasPresentacion
    {
        Task<List<Facturas>> Listar();
        Task<List<Facturas>> Buscar(Facturas entidad, string tipo);
        Task<Facturas> Guardar(Facturas entidad);
        Task<Facturas> Modificar(Facturas entidad);
        Task<Facturas> Borrar(Facturas entidad);
    }
}