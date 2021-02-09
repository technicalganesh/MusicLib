using System;
using System.Collections.Generic;
using System.Linq;
using Music.Entities;
using Music.Standards;


namespace Music.Store {
    public class DataRepository<T> : IDataRepository<T> where T : EntityBase {
        protected List<T> _entities { get; set; }
        public DataRepository () {
            _entities = new List<T> ();
        }
        public void Add (T entity) {
            _entities.Add (entity);
        }
        public List<T> GetAll () {
            return _entities;
        }
        public int Count () {
            return _entities.Count;
        }

        public T GetById (int id) {
            return _entities.FirstOrDefault (x => x.Id == id);
        }
    }
}