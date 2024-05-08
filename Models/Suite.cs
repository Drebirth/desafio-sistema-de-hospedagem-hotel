using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHospedagemHotel.Models
{
    public class Suite
    {

        public Suite (string nome, int capacidade, decimal valordia)
        {
            TipoSuite = nome;
            Capacidade = capacidade;
            ValorDiaria = valordia;
        }
        public string TipoSuite { get; set; }

        public int Capacidade { get; set; }

        public decimal ValorDiaria { get; set; }
    }
}