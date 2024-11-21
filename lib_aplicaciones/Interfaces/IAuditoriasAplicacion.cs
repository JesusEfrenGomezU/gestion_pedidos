using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IAuditoriasAplicacion
    {
        void Configurar(string string_conexion);
        List<Auditorias> Buscar(Auditorias entidad, string tipo);
        List<Auditorias> Listar();
        Auditorias Guardar(Auditorias entidad);
        Auditorias Modificar(Auditorias entidad);
        Auditorias Borrar(Auditorias entidad);
    }
}