using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class Vehiculo
    {
        public int Id { get; set; }
        public int IdCliente { get; set; }
        public string Placa { get; set; }
        public string Clase { get; set; }
        public string Marca { get; set; }
        public string Linea { get; set; }
        public string Combustible { get; set; }
        public string Modelo { get; set; }


        public Vehiculo(int id, int idCliente, string placa, string clase, string marca, string linea, string combustible, string modelo)
        {
            Id = id;
            IdCliente = idCliente;
            Placa = placa;
            Clase = clase;
            Marca = marca;
            Linea = linea;
            Combustible = combustible;
            Modelo = modelo;
        }

            public Vehiculo() : this(0,0, "", "", "", "", "", "")
        {
        }
    }
}
