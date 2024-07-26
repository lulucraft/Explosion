using Explosion.Context.Models;

namespace Explosion.Services
{
    public class PaysService(TpExplosionContext context) : IPaysService
    {
        public List<Pays> GetPays()
        {
            return [.. context.Pays];
        }
    }
}
