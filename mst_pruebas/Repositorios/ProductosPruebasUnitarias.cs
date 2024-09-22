using lib_entidades;
using lib_repositorios.Interfaces;
using lib_repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_repositorios.Implementaciones;
using mst_pruebas.Nucleo;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class ProductosPruebasUnitarias
    {
        private IProductos? iRepositorio = null;
        private Conexion? conexion = null;
        private Productos? entidad = null;
        private List<Productos>? lista = null;

        public ProductosPruebasUnitarias()
        {
            conexion = new Conexion();
            conexion!.StringConnection = ConfiguracionHelper.ObtenerValor("ConectionString");
            iRepositorio = new ProductosRepositorio(conexion);
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
            lista = iRepositorio!.Buscar(x => x.Id_prod != entidad!.Id_prod);
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
            entidad!.Nom_prod = entidad.Nom_prod + " Modificado Nom " + DateTime.Now.ToString();
            entidad = iRepositorio!.Modificar(entidad!);
            lista = iRepositorio!.Buscar(x => x.Id_prod == entidad.Id_prod);
            Assert.IsTrue(lista.Count > 0);
        }

        public void Guardar()
        {
            //mi clase de entidades no funciona de ninguna forma
            entidad = EntidadesHelper.ObtenerProductos();
            entidad = iRepositorio!.Guardar(entidad!);
            //Ese es el id correcto?
            Assert.IsTrue(entidad.Id_prod != 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            lista = iRepositorio!.Buscar(x => x.Id_prod == entidad!.Id_prod);
            Assert.IsTrue(lista.Count == 0);
        }




    }
}
