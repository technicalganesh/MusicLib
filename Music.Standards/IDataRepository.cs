using System;
using System.Collections.Generic;

namespace Music.Standards {
    public interface IDataRepository<T> where T : EntityBase {
        void Add (T entity);
        List<T> GetAll ();
        int Count ();
    }
}