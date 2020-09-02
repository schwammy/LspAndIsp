using System.Collections.Generic;

namespace LspAndIsp
{
    public interface IReadonlyRepository<T>
    {
        T Find(int id);
        IEnumerable<T> Get();
    }
}
