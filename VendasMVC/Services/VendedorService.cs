using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasMVC.Models;
using Microsoft.EntityFrameworkCore;
using VendasMVC.Services.Exceptions;

namespace VendasMVC.Services
{
    public class VendedorService
    {
        private readonly VendasMVCContext _content;

        public VendedorService(VendasMVCContext context)
        {
            this._content = context;
        }

        public async Task<List<Vendedor>> ListarTodosAsync()
        {
            return await _content.Vendedor.ToListAsync();
        }

        public async Task InsertAsync(Vendedor obj)
        {
            _content.Add(obj);
            await _content.SaveChangesAsync();
        }

        public async Task<Vendedor> ListarPorIdAsync(int id)
        {
            return await _content.Vendedor.Include(obj => obj.Departamento).FirstOrDefaultAsync(obj => obj.Id == id);
        }

        public async Task RemoverAsync(int id)
        {
            try
            {
                var obj = await _content.Vendedor.FindAsync(id);
                _content.Vendedor.Remove(obj);
                await _content.SaveChangesAsync();
            }
            catch (DbUpdateException e)
            {
                throw new IntegrityException(e.Message); 
            }
        }

        public async Task UpdateAsync(Vendedor obj)
        {
            if (! await _content.Vendedor.AnyAsync(x => x.Id == obj.Id)) 
            {
                throw new NotFoundException("Vendedor não encontrado!"); 
            }

            try
            {
                _content.Update(obj);
                await _content.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
                
        }

    }
}
