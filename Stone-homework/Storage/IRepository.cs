using Stone_homework.Models;

namespace Stone_homework.Storage
{
    public interface IRepository<T>
    {
        public void Add(T item);
        IEnumerable<T> GetAll();
        T GetById(int id);
        T GetByName(string name);
        void SaveChanges();

    }
}
