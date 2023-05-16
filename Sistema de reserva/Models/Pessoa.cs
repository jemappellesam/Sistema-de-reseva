using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_reserva.Models
{
    internal class Pessoa
    {
        private string nome;
        private string sobrenome;

        public string Nome
        {
            get => nome;
            set => nome = value;
        }
        public string Sobrenome
        {
            get => sobrenome;
            set => sobrenome = value;
        }

    }
}
