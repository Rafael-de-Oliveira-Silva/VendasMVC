using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasMVC.Models;
using VendasMVC.Models.Enum;

namespace VendasMVC.Data
{
    public class SeedingService
    {
        private VendasMVCContext _context;

        public SeedingService(VendasMVCContext context) 
        {
            this._context = context;
        }

        public void Seed() {
            if (_context.Departamento.Any() ||
                _context.Venda.Any() ||
                _context.Vendedor.Any()) 
            {
                return;
            }

            Departamento d1 = new Departamento(1, "Eletrônicos");
            Departamento d2 = new Departamento(2, "Eletrodomésticos");
            Departamento d3 = new Departamento(3, "Movéis");
            Departamento d4 = new Departamento(4, "Fitness");
            Departamento d5 = new Departamento(5, "Utensílios");
            Departamento d6 = new Departamento(6, "Cama/Mesa/Banho");

            Vendedor vd1 = new Vendedor(1, "João", "joao@gmail.com", new DateTime(1988, 07, 22), 1000.00, d1);
            Vendedor vd2 = new Vendedor(2, "Camila", "camila@gmail.com", new DateTime(1989, 12, 17), 1000.00, d2);
            Vendedor vd3 = new Vendedor(3, "Thais", "thais@gmail.com", new DateTime(1990, 10, 23), 1000.00, d3);
            Vendedor vd4 = new Vendedor(4, "Viviane", "viviane@gmail.com", new DateTime(1996, 09, 19), 1000.00, d4);
            Vendedor vd5 = new Vendedor(5, "Gilberto", "gilberto@gmail.com", new DateTime(1999, 02, 05), 1000.00, d5);
            Vendedor vd6 = new Vendedor(6, "Juliete", "juliente@gmail.com", new DateTime(2000, 06, 01), 1000.00, d6);
            Vendedor vd7 = new Vendedor(7, "Artur", "artur@gmail.com", new DateTime(2000, 07, 21), 1000.00, d2);
            Vendedor vd8 = new Vendedor(8, "Rodolfo", "rodolfo@gmail.com", new DateTime(1986, 04, 25), 1000.00, d4);
            Vendedor vd9 = new Vendedor(9, "Caio", "caio@gmail.com", new DateTime(1988, 04, 25), 1000.00, d3);
            Vendedor vd10 = new Vendedor(10, "Fiuk", "fiuk@gmail.com", new DateTime(1991, 05, 20), 1000.00, d5);

            Venda v1  = new Venda(1,  new DateTime(2021, 03, 17), 1100.50, StatusVenda.Faturado, vd2);
            Venda v2  = new Venda(2,  new DateTime(2021, 02, 17), 1200.60, StatusVenda.Faturado, vd1);
            Venda v3  = new Venda(3,  new DateTime(2021, 01, 23), 1320.50, StatusVenda.Faturado, vd2);
            Venda v4  = new Venda(4,  new DateTime(2021, 02, 01), 100.10, StatusVenda.Faturado, vd6);
            Venda v5  = new Venda(5,  new DateTime(2021, 02, 23), 354.50, StatusVenda.Faturado, vd5);
            Venda v6  = new Venda(6,  new DateTime(2021, 01, 14), 414.90, StatusVenda.Faturado, vd9);
            Venda v7  = new Venda(7,  new DateTime(2021, 02, 07), 2105.50, StatusVenda.Faturado, vd7);
            Venda v8  = new Venda(8,  new DateTime(2021, 03, 09), 1100.50, StatusVenda.Faturado, vd8);
            Venda v9  = new Venda(9,  new DateTime(2021, 02, 28), 1100.50, StatusVenda.Faturado, vd1);
            Venda v10 = new Venda(10, new DateTime(2021, 02, 03), 1401.70, StatusVenda.Faturado, vd9);
            Venda v11 = new Venda(11, new DateTime(2021, 04, 02), 1100.50, StatusVenda.Faturado, vd7);
            Venda v12 = new Venda(12, new DateTime(2021, 02, 22), 1100.50, StatusVenda.Faturado, vd2);
            Venda v13 = new Venda(13, new DateTime(2021, 03, 10), 1100.50, StatusVenda.Faturado, vd2);
            Venda v14 = new Venda(14, new DateTime(2021, 02, 14), 150.50, StatusVenda.Faturado, vd2);
            Venda v15 = new Venda(15, new DateTime(2021, 03, 07), 1100.50, StatusVenda.Faturado, vd10);
            Venda v16 = new Venda(16, new DateTime(2021, 02, 21), 135.50, StatusVenda.Faturado, vd2);
            Venda v17 = new Venda(17, new DateTime(2021, 02, 16), 1150.50, StatusVenda.Faturado, vd9);
            Venda v18 = new Venda(18, new DateTime(2021, 02, 15), 1500.50, StatusVenda.Faturado, vd2);
            Venda v19 = new Venda(19, new DateTime(2021, 01, 13), 1100.50, StatusVenda.Faturado, vd2);
            Venda v20 = new Venda(20, new DateTime(2021, 01, 08), 1100.50, StatusVenda.Faturado, vd9);
            Venda v21 = new Venda(21, new DateTime(2021, 02, 19), 1100.50, StatusVenda.Faturado, vd3);
            Venda v22 = new Venda(22, new DateTime(2021, 02, 15), 1100.50, StatusVenda.Faturado, vd2);
            Venda v23 = new Venda(23, new DateTime(2021, 04, 26), 1600.50, StatusVenda.Faturado, vd3);
            Venda v24 = new Venda(24, new DateTime(2021, 02, 24), 1700.50, StatusVenda.Faturado, vd4);
            Venda v25 = new Venda(25, new DateTime(2021, 03, 17), 1100.50, StatusVenda.Faturado, vd5);

            _context.Departamento.AddRange(d1, d2, d3, d4, d5, d6);
            _context.Vendedor.AddRange(vd1, vd2, vd3, vd4, vd5, vd6, vd7, vd8, vd9, vd10);
            _context.Venda.AddRange(v1, v2, v3, v4, v5, v6, v7, v8, v9, v10,
                                    v11, v12, v13, v14, v15, v16, v17, v18, 
                                    v19, v20, v21, v22, v23, v24, v25);
            _context.SaveChanges();
        }
    }
}
