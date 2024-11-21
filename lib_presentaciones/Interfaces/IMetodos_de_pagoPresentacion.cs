using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IMetodos_de_pagoPresentacion
    {
        Task<List<Metodos_de_pago>> Listar();
        Task<List<Metodos_de_pago>> Buscar(Metodos_de_pago entidad, string tipo);
        Task<Metodos_de_pago> Guardar(Metodos_de_pago entidad);
        Task<Metodos_de_pago> Modificar(Metodos_de_pago entidad);
        Task<Metodos_de_pago> Borrar(Metodos_de_pago entidad);
    }
}