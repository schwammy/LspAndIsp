
namespace LspAndIsp
{
    public interface IWriteableRepository<T> // maybe this?: IReadonlyRepository<T>
    {
        void Add(T item);
        void Update(T item);
        void Delete(T item);
    }
}
