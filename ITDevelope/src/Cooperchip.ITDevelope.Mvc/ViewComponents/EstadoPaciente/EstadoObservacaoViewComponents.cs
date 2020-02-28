using Cooperchip.ITDevelope.Mvc.ViewComponents.Helpers;
using Cooperchip.ITDeveloper.Data.ORM._Object_Relacional_Mapping;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Cooperchip.ITDevelope.Mvc.ViewComponents.EstadoPaciente
{
    public class EstadoObservacaoViewComponents : ViewComponent
    {
        private readonly ITDeveloperDbContext _context;
        public EstadoObservacaoViewComponents(ITDeveloperDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var totalGeral = Util.TotReg(_context);
            decimal totalEstado = Util.GetNumRegEstado(_context, "Observação");

            decimal progress = totalEstado * 100 / totalGeral;
            var pcrt = progress.ToString("F1");

            var model = new ContadorEstadoPaciente()
            {
                Titulo = "Paciente Em Observação",
                Parcial = (int)totalEstado,
                Percentual = pcrt,
                ClassContainer = "panel panel-default tile panelClose panelRefresh",
                IconeLg = "l-banknote",
                IconeSm = "fa fa-arrow-circle-o-down s20 mr5 pull-left",
                Progress = progress


            };
            return View(model);
        }

    }
}
