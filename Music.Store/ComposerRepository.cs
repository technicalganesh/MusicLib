using Music.Entities;
using Music.Standards;

namespace Music.Store
{
    public class ComposerRepository : DataRepository<Composer>
    {
        public Composer GetByCountry(string country)
        {
            return _entities.Find(x => x.Country == country);
        }
    }
}