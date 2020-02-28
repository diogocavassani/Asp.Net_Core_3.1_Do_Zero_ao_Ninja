using Cooperchip.ITDevelope.Mvc.ViewComponents.Helpers;
using Cooperchip.ITDeveloper.Data.ORM._Object_Relacional_Mapping;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Cooperchip.ITDevelope.Mvc.ViewComponents.EstadoPaciente
{
    [ViewComponent(Name = "EstadoGrave")]
    public class EstadoGraveViewComponents : ViewComponent
    {
        private readonly ITDeveloperDbContext _context;
        public EstadoGraveViewComponents(ITDeveloperDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var totalGeral = Util.TotReg(_context);
            decimal totalEstado = Util.GetNumRegEstado(_context, "Grave");

            decimal progress = totalEstado * 100 / totalGeral;
            var pcrt = progress.ToString("F1");

            var model = new ContadorEstadoPaciente()
            {
                Titulo = "Paciente Grave",
                Parcial = (int)totalEstado,
                Percentual = pcrt,
                ClassContainer = "panel panel-danger tile panelClose panelRefresh",
                IconeLg = "l-basic-life-buoy",
                IconeSm = "fa fa-arrow-circle-o-down s20 mr5 pull-left",
                Progress = progress


            };
            return View(model);
        }
    }
}
