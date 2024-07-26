using Explosion.Context.Models;
using Microsoft.EntityFrameworkCore;

namespace Explosion.Services
{
    public class ExplosionService(TpExplosionContext context) : IExplosionService
    {
        public List<Context.Models.Explosion> GetExplosions()
        {
            return [.. context.Explosions.Include(e => e.IdSiteNavigation).Include(e => e.IdTypeNavigation).Include(e => e.IdCategorieNavigation)];
        }
    }
}
