using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using lib_repositorios;
using mst_pruebas.Nucleo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_entidades.Modelos;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class RemitentesPruebasUnitarias
    {
        private IRemitentesRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Remitentes? entidad = null;
        private List<Remitentes>? lista = null;

        public RemitentesPruebasUnitarias()
        {
            conexion = new Conexion();
            conexion!.StringConnection = ConfiguracionHelper.ObtenerValor("ConectionString");
            iRepositorio = new RemitentesRepositorio(conexion);
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
           
            entidad!.Nombre = entidad.Nombre + " Modificado " + DateTime.Now.ToString();
            entidad = iRepositorio!.Modificar(entidad!);
            lista = iRepositorio!.Buscar(x => x.Id == entidad.Id);
            Assert.IsTrue(lista.Count > 0);
        }

        public void Guardar()
        {
            
            entidad = EntidadesHelper.ObtenerRemitentes();
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
