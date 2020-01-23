using System;
using System.Collections.Generic;
using System.Linq;

namespace Interview
{
    public class Repository<T, I> : IRepository<T, I> where T : IStoreable<I>
    {
        private List<T> Ts;

        public Repository()
        {
            Ts = new List<T>();
        }

        public void Delete(I id)
        {
            Ts.Remove(Get(id));
        }

        public T Get(I id)
        {
            return Ts.Where(r=>r.Id.Equals(id)).FirstOrDefault();
        }

        public IEnumerable<T> GetAll()
        {
            return Ts;
        }

        public void Save(T item)
        {
            Ts.Add(item);
        }
    }
}
