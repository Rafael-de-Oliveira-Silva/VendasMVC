using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace VendasMVC.Models
{
    public class Vendedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é obrigatório!")]
        [StringLength(60, MinimumLength = 3, ErrorMessage ="O nome do vendedor deve ter entre 3 e 60 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O email é obrigatório!")]
        [EmailAddress(ErrorMessage = "Informe um email válido!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "A data de nascimento é obrigatório!")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "O salário base é obrigatório!")]
        [Range(100.00, 50000.0, ErrorMessage = "Faixa de salário inválido! Mínimo: R$ 100,00 / Máximo: R$ 50.000,00")]
        [Display(Name = "Salário Base")]
        [DataType(DataType.Currency)]
        public double SalarioBase { get; set; }

        public Departamento Departamento { get; set; }
        public int DepartamentoId { get; set; }
        public ICollection<Venda> Vendas { get; set; } = new List<Venda>();

        public Vendedor()
        {

        }

        public Vendedor(int id, string nome, string email, DateTime dataNascimento, double salarioBase, Departamento departamento)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.DataNascimento = dataNascimento;
            this.SalarioBase = salarioBase;
            this.Departamento = departamento;
        }

        public void AdicionarVenda(Venda v)
        {
            Vendas.Add(v);
        }

        public void RemoverVenda(Venda v)
        {
            Vendas.Remove(v);
        }

        public double TotalVendasRealizadas(DateTime dtInicio, DateTime dtFim) 
        {
            return Vendas.Where(v => v.DataVenda >= dtInicio && v.DataVenda <= dtFim).Sum(v => v.ValorTotal);
        }
    }
}
