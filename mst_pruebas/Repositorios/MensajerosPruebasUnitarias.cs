using lib_repositorios.Interfaces;
using lib_repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lib_repositorios.Implementaciones;
using mst_pruebas.Nucleo;
using lib_entidades.Modelos;

namespace mst_pruebas.Repositorios
{
    [TestClass]
    public class MensajerosPruebasUnitarias
    {
        private IMensajeros? iRepositorio = null;
        private Conexion? conexion = null;
        private Mensajeros? entidad = null;
        private List<Mensajeros>? lista = null;

        public MensajerosPruebasUnitarias()
        {
            conexion = new Conexion();
            conexion!.StringConnection = ConfiguracionHelper.ObtenerValor("ConectionString");
            iRepositorio = new MensajerosRepositorio(conexion);
        }

        [TestMethod]
        public void Executar() {
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

        public void Modificar()
        {
            
            entidad!.Transportista = entidad.Transportista + " " + DateTime.Now.ToString();
            entidad = iRepositorio!.Modificar(entidad!);
            lista = iRepositorio!.Buscar(x => x.Id == entidad.Id);
            Assert.IsTrue(lista.Count > 0);
        }

        public void Guardar()
        {
            
            entidad = EntidadesHelper.ObtenerMensajeros();
            entidad = iRepositorio!.Guardar(entidad!);
            
            Assert.IsTrue(entidad.Id != 0);
        }

        private void Listar()
        {
            lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            lista = iRepositorio!.Buscar(x => x.Id == entidad!.Id);
            Assert.IsTrue(lista.Count == 0);
        }
    }
}
