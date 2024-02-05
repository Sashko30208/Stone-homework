using Stone_homework.Models;
using Stone_homework.Services.RequestModels;

namespace Stone_homework.Services
{
    public interface IVacancyService
    {
        Task<VacancyResponseModel> GetVacancyAsync(Guid id);
        Task<VacancyResponseModel> CreateVacancyAsync(CreateVacancyModel vacancy);
        Task<VacancyResponseModel> UpdateVacancyAsync(Vacancy vacancy);
        Task DeleteVacancyAsync(Vacancy vacancy);
    }
}
