using Explosion.Context.Models;
using Microsoft.EntityFrameworkCore;

namespace Explosion.Services
{
    public class ExplosionService : IExplosionService
    {
        private readonly TpExplosionContext _context;

        public ExplosionService(TpExplosionContext context)
        {
            _context = context;
        }

        public List<Context.Models.Explosion> GetExplosions()
        {
            return [.. _context.Explosions.Include(e => e.IdSiteNavigation)];
        }
    }
}
