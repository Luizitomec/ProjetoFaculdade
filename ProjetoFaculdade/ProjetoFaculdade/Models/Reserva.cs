using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoFaculdade.Models
{
    public class Reserva
    {
        public int IdReserva { get; set; }
        public DateTime DataReserva { get; set; }
        public Produto NomeProduto { get; set; }
        public Cliente NomeCliente { get; set; }


    }
}
