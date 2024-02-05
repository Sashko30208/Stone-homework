using Stone_homework.Models;
using Stone_homework.Storage.Base;

namespace Stone_homework.Storage.Implementation
{
    public class VacancyRepository : Repository<Guid, Vacancy, ApplicationDbContext>, IVacancyRepository
    {
        public VacancyRepository(ApplicationDbContext dbContext) : base(dbContext)
        { }

        public async Task<Vacancy> AddVacancy(Vacancy item)
        {
            //тут можно реализовать доп логику для хранения.
            return await base.Add(item);
        }

        public async Task DeleteVacancy(Vacancy item)
        {
            await base.Delete(item);
        }

        public async Task<Vacancy> GetVacancy(Guid id)
        {
            return await base.Get(id);
        }

        public async Task<Vacancy> GetVacancy(Vacancy item)
        {
            return await base.Get(item);
        }

        public async Task<Vacancy> UpdateVacancy(Vacancy item)
        {
            return await base.Update(item);
        }
    }
}
