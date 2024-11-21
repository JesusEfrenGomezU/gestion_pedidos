using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IPedidosPresentacion
    {
        Task<List<Pedidos>> Listar();
        Task<List<Pedidos>> Buscar(Pedidos entidad, string tipo);
        Task<Pedidos> Guardar(Pedidos entidad);
        Task<Pedidos> Modificar(Pedidos entidad);
        Task<Pedidos> Borrar(Pedidos entidad);
    }
}