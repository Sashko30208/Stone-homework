using Stone_homework.Models;

namespace Stone_homework.Storage.Base
{
    public interface IRepository<TKey, T> where T : BaseEntity<TKey>
    {
        public Task<T> Add(T item);
        public Task<T> Update(T item);
        public Task<bool> Delete(T item);
        public Task<IEnumerable<T>> GetAll();
        public Task<T> Get(TKey id);
        public Task<T> Get(T item);
    }
}
