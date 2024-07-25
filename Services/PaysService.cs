using Explosion.Context.Models;
using Microsoft.EntityFrameworkCore;

namespace Explosion.Services
{
    public class PaysService : IPaysService
    {
        private readonly TpExplosionContext _context;

        public PaysService(TpExplosionContext context)
        {
            _context = context;
        }

        public List<Pays> GetPays()
        {
            return [.. _context.Pays];
        }
    }
}
