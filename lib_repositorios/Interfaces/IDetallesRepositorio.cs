﻿using lib_entidades.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace lib_repositorios.Interfaces
{
    public interface IDetallesRepositorio
    {
        void Configurar(string string_conexion);
        List<Detalles> Listar();
        List<Detalles> Buscar(Expression<Func<Detalles, bool>> condiciones);
        Detalles Guardar(Detalles entidad);

        Detalles Modificar(Detalles entidad);

        Detalles Borrar(Detalles entidad);

        bool Existe(Expression<Func<Detalles, bool>> condiciones);
    }
}
