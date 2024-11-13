using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using mst_pruebas.Nucleo;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class FacturasPruebasUnitarias
    {
        private IFacturas? iRepositorio = null;
        private Conexion? conexion = null;
        private Facturas? entidad = null;
        private List<Facturas>? lista = null;

        public FacturasPruebasUnitarias()
        {
            conexion = new Conexion();
            conexion!.StringConnection = ConfiguracionHelper.ObtenerValor("ConectionString");
            iRepositorio = new FacturasRepositorio(conexion);
        }

        [TestMethod]
        public void Executar()
        {
            Guardar();
            Listar();
            Buscar();
            Modificar();
            Borrar();
        }

        public void Buscar()
        {
            lista = iRepositorio!.Buscar(x => x.Id_fac != entidad!.Id_fac);
            Assert.IsTrue(lista.Count > 0);
        }

        private void Listar()
        {
            lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }

        public void Modificar()
        {
            //solo me modifica el nombre añadiendo un string y una fecha que se pasa a string
            //de la misma forma se puede modificar a gusto cualquier otra cosa de la entidad y ramificaciones 
            entidad!.Cliente!.Nombre = entidad.Cliente.Nombre + " Modificado " + DateTime.Now.ToString(); 
            entidad = iRepositorio!.Modificar(entidad!);
            lista = iRepositorio!.Buscar(x => x.Id_fac == entidad.Id_fac);
            Assert.IsTrue(lista.Count > 0);
        }

        public void Guardar()
        {
            //mi clase de entidades no funciona de ninguna forma
            entidad = EntidadesHelper.ObtenerFacturas();
            entidad = iRepositorio!.Guardar(entidad!);
            //Ese es el id correcto?
            Assert.IsTrue(entidad.Id_fac != 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            lista = iRepositorio!.Buscar(x => x.Id_fac == entidad!.Id_fac);
            Assert.IsTrue(lista.Count == 0);
        }

    }
}