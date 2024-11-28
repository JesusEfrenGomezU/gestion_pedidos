using lib_entidades.Modelos;
using lib_presentaciones.Interfaces;
using lib_utilidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp_presentacion.Pages.Ventanas
{
    public class FacturasModel : PageModel
    {
        private IFacturasPresentacion? iPresentacion = null;
        private IMetodos_de_pagoPresentacion? iMetodos_de_pagoPresentacion = null; 
        private IClientesPresentacion? iClientesPresentacion = null; 
        private IRemitentesPresentacion? iRemitentesPresentacion = null; 
        private IMensajerosPresentacion? iMensajerosPresentacion = null; 
        private IDetallesPresentacion? iDetallesPresentacion = null; 

        public FacturasModel(
            IFacturasPresentacion iPresentacion,
            IMetodos_de_pagoPresentacion iMetodos_de_pagoPresentacion,
            IClientesPresentacion iClientesPresentacion,
            IRemitentesPresentacion iRemitentesPresentacion,
            IMensajerosPresentacion iMensajerosPresentacion,
            IDetallesPresentacion iDetallesPresentacion)
        {
            try
            {
                this.iPresentacion = iPresentacion;
                this.iMetodos_de_pagoPresentacion = iMetodos_de_pagoPresentacion;
                this.iClientesPresentacion = iClientesPresentacion;
                this.iRemitentesPresentacion = iRemitentesPresentacion;
                this.iMensajerosPresentacion = iMensajerosPresentacion;
                this.iDetallesPresentacion = iDetallesPresentacion;
                Filtro = new Facturas();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        [BindProperty] public Enumerables.Ventanas Accion { get; set; }
        [BindProperty] public Facturas? Actual { get; set; }
        [BindProperty] public Facturas? Filtro { get; set; }
        [BindProperty] public List<Facturas>? Lista { get; set; }
        [BindProperty] public List<Clientes>? Clientes { get; set; }
        [BindProperty] public List<Metodos_de_pago>? MetodosDePago { get; set; }
        [BindProperty] public List<Remitentes>? Remitentes { get; set; }
        [BindProperty] public List<Mensajeros>? Mensajeros { get; set; }
        [BindProperty] public List<Detalles>? Detalles { get; set; }

        public virtual void OnGet() { OnPostBtRefrescar(); }

        public void OnPostBtRefrescar()
        {
            try
            {
                Filtro!.cliente = Filtro!.cliente ?? "";

                Accion = Enumerables.Ventanas.Listas;
                var task = this.iPresentacion!.Buscar(Filtro!, "CLIENTE");
                task.Wait();
                Lista = task.Result;
                CargarCombox();
                Actual = null;
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public virtual void OnPostBtNuevo()
        {
            try
            {
                Accion = Enumerables.Ventanas.Editar;
                CargarCombox();
                Actual = new Facturas();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public virtual void OnPostBtModificar(string data)
        {
            try
            {
                OnPostBtRefrescar();
                Accion = Enumerables.Ventanas.Editar;
                Actual = Lista!.FirstOrDefault(x => x.id_fac.ToString() == data);
                CargarCombox();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public virtual async Task<IActionResult> OnPostBtGuardarAsync()
        {
            Accion = Enumerables.Ventanas.Editar;

            if (Actual == null)
            {
                Actual = new Facturas();
            }

            try
            {
                Task<Facturas>? task = null;
                if (Actual.id_fac == 0)
                {
                    task = this.iPresentacion!.Guardar(Actual!);
                }
                else
                {
                    task = this.iPresentacion!.Modificar(Actual!);
                }
                task.Wait();
                Actual = task.Result;
                Accion = Enumerables.Ventanas.Listas;
                OnPostBtRefrescar();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }

            return RedirectToPage();
        }

        public virtual void OnPostBtBorrarVal(string data)
        {
            try
            {
                OnPostBtRefrescar();
                Accion = Enumerables.Ventanas.Borrar;
                Actual = Lista!.FirstOrDefault(x => x.id_fac.ToString() == data);
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public virtual void OnPostBtBorrar()
        {
            try
            {
                var task = this.iPresentacion!.Borrar(Actual!);
                Actual = task.Result;
                OnPostBtRefrescar();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void OnPostBtCancelar()
        {
            try
            {
                Accion = Enumerables.Ventanas.Listas;
                OnPostBtRefrescar();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void OnPostBtCerrar()
        {
            try
            {
                if (Accion == Enumerables.Ventanas.Listas)
                    OnPostBtRefrescar();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public void CargarCombox()
        {
            try
            {
                // Cargar Clientes
                if (Clientes == null || Clientes!.Count <= 0)
                {
                    var taskClientes = this.iClientesPresentacion!.Listar();
                    taskClientes.Wait();
                    Clientes = taskClientes.Result;
                }

                // Cargar Métodos de Pago
                if (MetodosDePago == null || MetodosDePago!.Count <= 0)
                {
                    var taskMetodosDePago = this.iMetodosPagoPresentacion!.Listar();
                    taskMetodosDePago.Wait();
                    MetodosDePago = taskMetodosDePago.Result;
                }

                // Cargar Remitentes
                if (Remitentes == null || Remitentes!.Count <= 0)
                {
                    var taskRemitentes = this.iRemitentesPresentacion!.Listar();
                    taskRemitentes.Wait();
                    Remitentes = taskRemitentes.Result;
                }

                // Cargar Mensajeros
                if (Mensajeros == null || Mensajeros!.Count <= 0)
                {
                    var taskMensajeros = this.iMensajerosPresentacion!.Listar();
                    taskMensajeros.Wait();
                    Mensajeros = taskMensajeros.Result;
                }

                // Cargar Detalles
                if (Detalles == null || Detalles!.Count <= 0)
                {
                    var taskDetalles = this.iDetallesPresentacion!.Listar();
                    taskDetalles.Wait();
                    Detalles = taskDetalles.Result;
                }
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }
    }
}