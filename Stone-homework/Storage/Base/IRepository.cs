using Stone_homework.Models;

namespace Stone_homework.Storage.Base
{
    public interface IRepository<TKey, T> where T : BaseEntity<TKey>
    {
        Task<T> Add(T item);
        Task<T> Update(T item);
        Task<bool> Delete(T item);
        Task<IEnumerable<T>> GetAll();
        Task<T> Get(TKey id);
        Task<T> Get(T item);
    }
}
