using Stone_homework.Models;
using Stone_homework.Storage.Base;

namespace Stone_homework.Storage
{
    public interface IVacancyRepository : IRepository<Guid, Vacancy>
    {
        Task<Vacancy> GetVacancy(Guid id);
        Task<Vacancy> GetVacancy(Vacancy item);
        Task<Vacancy> AddVacancy(Vacancy vacancy);
        Task DeleteVacancy(Vacancy vacancy);
        Task<Vacancy> UpdateVacancy(Vacancy vacancy);

    }
}
