using Microsoft.EntityFrameworkCore;
using Stone_homework.Models;

namespace Stone_homework.Storage.Base
{
    public class Repository<TKey, T, TDbContext> : IRepository<TKey, T>
        where T : BaseEntity<TKey>
        where TDbContext : DbContext
    {
        private TDbContext _context;
        protected TDbContext DbContext
        {
            get { return _context; }
        }

        public Repository(TDbContext context)
            => _context = context;

        public async Task<T> Add(T item)
        {
            try
            {
                //тут еще должен быть маппер, дто'шка, но сделал одним объектом для упрощения. В реальном проекте так не поступают
                DbContext.DetachAll();
                DbContext.Add(item);
                await DbContext.SaveChangesAsync();
                return item;
            }
            catch (Exception) { throw; }
            finally
            { DbContext.Entry(item).State = EntityState.Detached; }
        }

        public async Task<T> Update(T item)
        {
            try
            {
                DbContext.DetachAll();
                DbContext.Attach(item);
                DbContext.Entry(item).State = EntityState.Modified;

                await DbContext.SaveChangesAsync();
            }
            catch (Exception) { throw; }
            finally { DbContext.Entry(item).State = EntityState.Detached; }
            return item;
        }

        public async Task<bool> Delete(T item)
        {
            if (item == null) throw new ArgumentNullException("Был передан пустой объект для удаления.");
            try
            {
                item = await Get(item);

                DbContext.DetachAll();

                DbContext.Remove(item);
                await DbContext.SaveChangesAsync();
                return true;
            }
            catch (EntityNotFoundException) { return false; }
            catch (Exception) { throw; }
            finally { DbContext.Entry(item).State = EntityState.Detached; }
        }

        public async Task<T> Get(TKey id)
        {
            if (id == null) { throw new EntityNotFoundException("Был передан пустой ключ."); }

            try
            {
                T? item = await DbContext.FindAsync<T>(id);
                if (item == null) { throw new EntityNotFoundException("Объект не найден."); }
                DbContext.Entry(item).State = EntityState.Detached;
                return item;
            }
            catch (Exception) { throw; }
            finally { DbContext.DetachAll(); }//надо подумать как сделать лучше. с ходу не придумал
        }

        public Task<T> Get(T item)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
