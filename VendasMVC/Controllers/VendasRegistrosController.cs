using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VendasMVC.Services;

namespace VendasMVC.Controllers
{
    public class VendasRegistrosController : Controller
    {
        private readonly RegistroVendaService _registroVendaService;

        public VendasRegistrosController(RegistroVendaService registroVendaService)
        {
            _registroVendaService = registroVendaService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> BuscaSimples(DateTime? dataIni, DateTime? dataFim)
        {
            if (!dataIni.HasValue) 
            {
                dataIni = new DateTime(DateTime.Now.Year, 1, 1);
            }

            if (!dataFim.HasValue) 
            {
                dataFim = DateTime.Now;
            }

            ViewData["DataIni"] = dataIni.Value.ToString("dd-MM-yyyy");
            ViewData["DataFim"] = dataFim.Value.ToString("dd-MM-yyyy");
            var result = await _registroVendaService.BuscaPorDataAsync(dataIni,dataFim);
            return View(result);
        }

        public async Task<IActionResult> BuscaAgrupada(DateTime? dataIni, DateTime? dataFim)
        {
            if (!dataIni.HasValue)
            {
                dataIni = new DateTime(DateTime.Now.Year, 1, 1);
            }

            if (!dataFim.HasValue)
            {
                dataFim = DateTime.Now;
            }

            ViewData["DataIni"] = dataIni.Value.ToString("dd-MM-yyyy");
            ViewData["DataFim"] = dataFim.Value.ToString("dd-MM-yyyy");
            var result = await _registroVendaService.BuscaAgrupadaPorDataAsync(dataIni, dataFim);
            return View(result);
        }
    }
}
