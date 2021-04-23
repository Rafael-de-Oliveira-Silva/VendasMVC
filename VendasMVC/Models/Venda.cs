using System;
using VendasMVC.Models.Enum;

namespace VendasMVC.Models
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime DataVenda { get; set; }
        public double ValorTotal { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public Venda() 
        { 

        }

        public Venda(int id, DateTime dataVenda, double valorTotal, StatusVenda status, Vendedor vendedor)
        {
            this.Id = id;
            this.DataVenda = dataVenda;
            this.ValorTotal = valorTotal;
            this.Status = status;
            this.Vendedor = vendedor;
        }
    }
}
