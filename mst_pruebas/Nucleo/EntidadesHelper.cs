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
