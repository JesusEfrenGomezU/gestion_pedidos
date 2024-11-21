using lib_entidades.Modelos;

namespace lib_aplicaciones.Interfaces
{
    public interface IFacturasAplicacion
    {
        void Configurar(string string_conexion);
        List<Facturas> Buscar(Facturas entidad, string tipo);
        List<Facturas> Listar();
        Facturas Guardar(Facturas entidad);
        Facturas Modificar(Facturas entidad);
        Facturas Borrar(Facturas entidad);
    }
}