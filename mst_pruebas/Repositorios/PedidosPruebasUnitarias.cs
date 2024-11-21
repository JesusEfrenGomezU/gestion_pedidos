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
    public class PedidosPruebasUnitarias
    {
        private IPedidosRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Pedidos? entidad = null;
        private List<Pedidos>? lista = null;

        public PedidosPruebasUnitarias()
        {
            conexion = new Conexion();
            conexion!.StringConnection = ConfiguracionHelper.ObtenerValor("ConectionString");
            iRepositorio = new PedidosRepositorio(conexion);
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
             
            entidad!.Descripcion = entidad.Descripcion + " Modificado Descrip " + DateTime.Now.ToString();
            entidad = iRepositorio!.Modificar(entidad!);
            lista = iRepositorio!.Buscar(x => x.Id == entidad.Id);
            Assert.IsTrue(lista.Count > 0);
        }

        public void Guardar()
        {
           
            entidad = EntidadesHelper.ObtenerPedidos();
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
