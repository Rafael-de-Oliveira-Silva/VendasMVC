using System;
using System.Collections.Generic;
using System.Linq;

namespace VendasMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedores { get; set; } = new List<Vendedor>();

        public Departamento() 
        {
            
        }

        public Departamento(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }

        public void AdicionarVendedor(Vendedor v) 
        {
            Vendedores.Add(v);
        }

        public double TotalVendasDepartamento(DateTime dtInicio, DateTime dtFim) 
        {
            return Vendedores.Sum(vendedor => vendedor.TotalVendasRealizadas(dtInicio,dtFim));  
        }
    }
}
