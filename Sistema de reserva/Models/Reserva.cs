using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_reserva.Models
{
    internal class Reserva
    {
        private List<Pessoa> hospedes;
        private Suite suite;
        private int diasReservados;
        public List<Pessoa> Hospedes
        {
            get => hospedes;
            set => hospedes = value;

        }
        public Suite Suite
        {
           get=> suite; 
           set => suite = value;
        }
        public int DiasReservados
        {
            get => diasReservados;
            set => diasReservados = value;
        }    
        public void CadastrarHospedes(List<Pessoa> hospedes)

        {
            if (hospedes.Count > Suite.Capacidade)
            {
                throw new Exception("Quantidade de hospedes maior que o suportado");
            }
            Hospedes = hospedes;

        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count;
        }
        public decimal CalcularValorDiaria()
        {
            if (DiasReservados > 10)
            {
                return Convert.ToInt16((Suite.ValorDiaria * 0, 9)) * DiasReservados;
            }
            else return Suite.ValorDiaria * DiasReservados;
        }
    }
}
