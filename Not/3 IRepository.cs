using System.Collections.Generic;

namespace Not
{
    public interface IRepository<T>
    {
        T Find(int id);
        IEnumerable<T> Get();
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}
