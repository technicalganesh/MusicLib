using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Music.Standards;

namespace Music.Store {
    public class SQLiteDataRepository<T> : IDataRepository<T> where T : EntityBase {

        protected MusicContext _musicContext;
        protected DbSet<T> _entities;
        public SQLiteDataRepository (MusicContext musicContext) {
            _musicContext = musicContext;
            _entities = musicContext.Set<T>();
        }
        public void Add (T entity) {
            _entities.Add(entity);
            _musicContext.SaveChanges();
        }

        public int Count () {
            return _entities.Count();
        }

        public List<T> GetAll () {
            return _entities.ToList();
        }
    }
}