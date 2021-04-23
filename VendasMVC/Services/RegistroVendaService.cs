using System.Linq;
using VendasMVC.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;

namespace VendasMVC.Services
{
    public class RegistroVendaService
    {
        private readonly VendasMVCContext _content;

        public RegistroVendaService(VendasMVCContext context)
        {
            this._content = context;
        }

        public async Task<List<Venda>> BuscaPorDataAsync(DateTime? dataIni, DateTime? dataFim) 
        {
            var result = from obj in _content.Venda select obj;

            if (dataIni.HasValue) 
            {
                result = result.Where(x => x.DataVenda >= dataIni.Value);
            }

            if (dataFim.HasValue) 
            {
                result = result.Where(x => x.DataVenda <= dataFim.Value);
            }

            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.DataVenda)
                .ToListAsync();
        }

        public async Task<List<IGrouping<Departamento,Venda>>> BuscaAgrupadaPorDataAsync(DateTime? dataIni, DateTime? dataFim)
        {
            var result = from obj in _content.Venda select obj;

            if (dataIni.HasValue)
            {
                result = result.Where(x => x.DataVenda >= dataIni.Value);
            }

            if (dataFim.HasValue)
            {
                result = result.Where(x => x.DataVenda <= dataFim.Value);
            }

            return await result
                .Include(x => x.Vendedor)
                .Include(x => x.Vendedor.Departamento)
                .OrderByDescending(x => x.DataVenda)
                .GroupBy(x => x.Vendedor.Departamento)
                .ToListAsync();
        }




    }
}
