using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IPedidosAplicacion
    {
        void Configurar(string string_conexion);
        List<Pedidos> Buscar(Pedidos entidad, string tipo);
        List<Pedidos> Listar();
        Pedidos Guardar(Pedidos entidad);
        Pedidos Modificar(Pedidos entidad);
        Pedidos Borrar(Pedidos entidad);
    }
}