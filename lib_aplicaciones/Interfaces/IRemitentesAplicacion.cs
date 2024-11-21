using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IRemitentesAplicacion
    {
        void Configurar(string string_conexion);
        List<Remitentes> Buscar(Remitentes entidad, string tipo);
        List<Remitentes> Listar();
        Remitentes Guardar(Remitentes entidad);
        Remitentes Modificar(Remitentes entidad);
        Remitentes Borrar(Remitentes entidad);
    }
}