using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_reserva.Models
{
    internal class Suite
    {
        private string tiposuite;
        private int capacidade;
        private decimal valorDiaria;

        public string TipoSuite
        {
            get => tiposuite; set => tiposuite = value;

        }
        public int Capacidade
        {
            get => capacidade; set => capacidade = value;
        }
        public decimal ValorDiaria
        {
                get => valorDiaria; set => valorDiaria = value;
        }
    }
}
