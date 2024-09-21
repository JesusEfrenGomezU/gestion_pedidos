﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Primitives;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mst_pruebas.Nucleo
{
    public class ConfiguracionHelper : IConfiguration
    {
        private static Dictionary<string, string>? datos = null;

        public string? this[string key]
        {
            get { return datos![key]; }
            set { datos![key] = value!; }
        }

        public static void Cargar()
        {
            datos = new Dictionary<string, string>();
            string path = @"C:\Users\user\source\repos\gestion_pedidos\mst_pruebas\Repositorios\secrets.json";
            StreamReader jsonStream = File.OpenText(path);
            var json = jsonStream.ReadToEnd();
            var temp = JsonConvert.DeserializeObject<Dictionary<string, string>>(json)!;
            foreach (var elemeto in temp)
                datos[elemeto.Key] = elemeto.Value;
        }

        public static string ObtenerValor(string clave)
        {
            if (datos == null)
                Cargar();
            return datos![clave]!.ToString()!;
        }

        public IEnumerable<IConfigurationSection> GetChildren()
        {
            throw new NotImplementedException();
        }

        public IChangeToken GetReloadToken()
        {
            throw new NotImplementedException();
        }

        public IConfigurationSection GetSection(string key)
        {
            throw new NotImplementedException();
        }
    }
}
