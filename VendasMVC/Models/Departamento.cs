
namespace VendasMVC.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Departamento(int id, string nome) {
            this.Id = id;
            this.Nome = nome;
        }
    }
}
