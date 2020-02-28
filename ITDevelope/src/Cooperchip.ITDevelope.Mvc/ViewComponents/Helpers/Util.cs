using Cooperchip.ITDeveloper.Data.ORM._Object_Relacional_Mapping;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Cooperchip.ITDevelope.Mvc.ViewComponents.Helpers
{
    public static class Util
    {
        public static int TotReg(ITDeveloperDbContext ctx)
        {
            return (from pac in ctx.Paciente.AsNoTracking() select pac).Count() ;
        }

        public static decimal GetNumRegEstado(ITDeveloperDbContext ctx, string estado)
        {
            return ctx.Paciente
                .Include(x=>x.EstadoPaciente).AsNoTracking()
                .Count(x=>x.EstadoPaciente.Descricao.Contains(estado));
        }
    }
}
