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
    public class Metodos_de_pagoPruebasUnitarias
    {
        private IMetodos_de_pagoRepositorio? iRepositorio = null;
        private Conexion? conexion = null;
        private Metodos_de_pago? entidad = null;
        private List<Metodos_de_pago>? lista = null;

        public Metodos_de_pagoPruebasUnitarias()
        {
            conexion = new Conexion();
            conexion!.StringConnection = ConfiguracionHelper.ObtenerValor("ConectionString");
            iRepositorio = new Metodos_de_pagoRepositorio(conexion);
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
            lista = iRepositorio!.Buscar(x => x.Id_pag != entidad!.Id_pag);
            Assert.IsTrue(lista.Count > 0);
        }

        private void Listar()
        {
            lista = iRepositorio!.Listar();
            Assert.IsTrue(lista.Count > 0);
        }

        public void Modificar()
        {

            entidad!.Tipo = entidad.Tipo + " Ejemplo" + DateTime.Now.ToString();
            entidad = iRepositorio!.Modificar(entidad!);
            lista = iRepositorio!.Buscar(x => x.Id_pag == entidad.Id_pag);
            Assert.IsTrue(lista.Count > 0);
        }

        public void Guardar()
        {
            
            entidad = EntidadesHelper.ObtenerMetodos_de_pago();
            entidad = iRepositorio!.Guardar(entidad!);
            
            Assert.IsTrue(entidad.Id_pag != 0);
        }

        public void Borrar()
        {
            entidad = iRepositorio!.Borrar(entidad!);

            lista = iRepositorio!.Buscar(x => x.Id_pag == entidad!.Id_pag);
            Assert.IsTrue(lista.Count == 0);
        }

    }
}
