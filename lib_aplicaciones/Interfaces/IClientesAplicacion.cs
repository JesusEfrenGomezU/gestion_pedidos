using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IClientesAplicacion
    {
        void Configurar(string string_conexion);
        List<Clientes> Buscar(Clientes entidad, string tipo);
        List<Clientes> Listar();
        Clientes Guardar(Clientes entidad);
        Clientes Modificar(Clientes entidad);
        Clientes Borrar(Clientes entidad);
    }
}