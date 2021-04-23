using System.Linq;
using VendasMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace VendasMVC.Services
{
    public class DepartamentoService
    {
        private readonly VendasMVCContext _content;

        public DepartamentoService(VendasMVCContext context)
        {
            this._content = context;
        }

        public async Task<List<Departamento>> ListarTodosAsync()
        {
            return await _content.Departamento.OrderBy(x => x.Nome).ToListAsync();
        }


    }
}
