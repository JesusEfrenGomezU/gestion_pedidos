using lib_entidades.Modelos;
using lib_repositorios;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using mst_pruebas.Nucleo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class DetallesPruebasUnitarias
    {
        private IDetalles? iRepositorio = null;
        private Conexion? conexion = null;
        private Detalles? entidad = null;
        private List<Detalles>? lista = null;
        public DetallesPruebasUnitarias()
        {
            conexion = new Conexion();
            conexion!.StringConnection = ConfiguracionHelper.ObtenerValor("ConectionString");
            iRepositorio = new DetallesRepositorio(conexion);
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
            lista = iRepositorio!.Buscar(x => x.Id != entidad!.Id);
            Assert.IsTrue(lista.Count > 0);
        }

        private void Listar()
        {
            lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }

        public void Modificar()
        {
            
            entidad!.Producto!.Nom_prod = entidad.Producto.Nom_prod + " Modificado prod " + DateTime.Now.ToString();
            entidad = iRepositorio!.Modificar(entidad!);
            lista = iRepositorio!.Buscar(x => x.Id == entidad.Id);
            Assert.IsTrue(lista.Count > 0);
        }

        public void Guardar()
        {
            
            entidad = EntidadesHelper.ObtenerDetalles();
            entidad = iRepositorio!.Guardar(entidad!);
            
            Assert.IsTrue(entidad.Id != 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            lista = iRepositorio!.Buscar(x => x.Id == entidad!.Id);
            Assert.IsTrue(lista.Count == 0);
        }


    }
}
