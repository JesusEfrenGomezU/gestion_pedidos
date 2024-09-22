using lib_entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mst_pruebas.Nucleo
{
    internal class EntidadesHelper
    {
        public static Remitentes ObtenerRemitentes() {
            return new Remitentes()
            {
                Nombre = "Jaime",
                Direcc_rem = "carrera 15#516-415"
            };
        }
        public static Pedidos ObtenerPedidos() {
            return new Pedidos()
            {
                Cod_pedido = 777,
                Descripcion = "Pedido de productos electrónicos",
                Medidas = "50x40x30",
                Estado = "Entregado",
                Remi = new Remitentes()
                {
                    Nombre = "Proveedor XYZ",
                    Direcc_rem = "Calle 849-4584-54"
                }
            };
        }
        public static Productos ObtenerProductos() {
            return new Productos()
            {
                Cantidad = 5,
                Precio = 2500.5m,
                Iva = 18.9m,
                Nom_prod = "Chicharron"
            };
        }
        public static Detalles ObtenerDetalles() {
            return new Detalles()
            {
                Producto = new Productos()
                {
                    
                    Nom_prod = "Producto B",
                    Precio = 150.0m,
                    Cantidad = 5,
                    Iva = 0.16m
                },
                Pedido = new Pedidos()
                {
                    
                    Cod_pedido = 555,
                    Descripcion = "Pedido B",
                    Medidas = "40x30x20",
                    Estado = "En camino",
                    Remi = new Remitentes()
                    {
                        
                        Nombre = "Remitente B",
                        Direcc_rem = "Avenida 58"
                    }
                }
            };
        }

        public static Clientes ObtenerClientes() {
            return new Clientes()
            {
                Nombre = "Juan",
                Cedula = "123245678",
                Telefono = "3154789565",
                Direcc = "Carrera 547-44-445"
            };
        }

        public static Metodos_de_pago ObtenerMetodos_de_pago() {
            return new Metodos_de_pago()
            {
                Tipo = "Efectivo Ejemplo"
            };
        }


        //Metodo inicializar Mensajeros
        public static Mensajeros ObtenerMensajeros() {
            return new Mensajeros()
            {
                Transportista = "Transportista Ejemplo"
            };
        
        }

        //Metodo inicializar Facturas
        public static Facturas ObtenerFacturas()
        {
            return new Facturas()
            {
                
                Cliente = new Clientes() {
                    
                    Cedula = "1234567890",
                    Nombre = "Jose Perez",
                    Telefono = "123-456-7890",
                    Direcc = "Calle 123, Ciudad"
                },
                Fecha = DateTime.Now, 
                M_pago = new Metodos_de_pago() {
                    
                    Tipo = "Tarjeta de crédito"
                },
                Iva = 0.19m,
                Total = 1000.0m,
                Details = new Detalles() {
                    
                    Producto = new Productos()
                    {
                        
                        Nom_prod = "Producto A",
                        Precio = 100.0m,
                        Cantidad = 10,
                        Iva = 0.16m
                    },
                    Pedido = new Pedidos() {
                        
                        Cod_pedido = 101,
                        Descripcion = "Pedido A",
                        Medidas = "30x20x10",
                        Estado = "Enviado",
                        Remi = new Remitentes()
                        {
                            
                            Nombre = "Remitente 1",
                            Direcc_rem = "Calle Remitente"
                        }
                    }
                },
                Remi = new Remitentes()
                {
                    
                    Nombre = "Remitente 1",
                    Direcc_rem = "Calle Remitente"
                },
                Menj = new Mensajeros() {
                    
                    Transportista = "Transportista 1"
                }
            };
        }
    }
}
