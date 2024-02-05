using Stone_homework.Models;
using Stone_homework.Services.RequestModels;
using Stone_homework.Storage;

namespace Stone_homework.Services.Implementation
{
    public class VacancyService : IVacancyService
    {
        private readonly IVacancyRepository _vacancyRepository;
        private readonly IDepartmentService _departmentService;
        public VacancyService(IVacancyRepository vacancyRepository, IDepartmentService departmentService)
        {
            _vacancyRepository = vacancyRepository;
            _departmentService = departmentService;
        }

        public async Task<VacancyResponseModel> CreateVacancyAsync(CreateVacancyModel vacancy)
        {
            Vacancy vacancyModel = new Vacancy()
            {
                ID = vacancy.ID,
                CreateDate = DateTime.UtcNow,
                DepartmentID = vacancy.DepartmentID,
                ResponsiblePersonID = vacancy.ResponsiblePersonID,
                EmailLink = vacancy.EmailLink,
                Name = vacancy.Name
            };
            //тут заполняем недостающие данные, обращаясь к соответствующим сервисам
            if (vacancyModel.DepartmentID is not null)
            {
                vacancyModel.Department = await _departmentService.GetDepartmentAsync(vacancyModel.DepartmentID.Value);
            }

            //not implemented
            //vacancyModel.Department;
            //vacancyModel.ResponsiblePerson;
            //vacancyModel.Tags;
            return ToResponceModel(await _vacancyRepository.AddVacancy(vacancyModel));
        }

        public async Task DeleteVacancyAsync(Vacancy vacancy)
        {
            await _vacancyRepository.DeleteVacancy(vacancy);
        }

        public async Task<VacancyResponseModel> GetVacancyAsync(Guid id)
        {
            return ToResponceModel(await _vacancyRepository.GetVacancy(id));
        }

        public async Task<VacancyResponseModel> UpdateVacancyAsync(Vacancy vacancy)
        {
            return ToResponceModel(await _vacancyRepository.UpdateVacancy(vacancy));
        }

        private static VacancyResponseModel ToResponceModel(Vacancy vacancy)
        {
            return new VacancyResponseModel()
            {
                EmailLink = vacancy.EmailLink,
                DepartmentName = vacancy.Department.Name,
                ID = vacancy.ID,
                Name = vacancy.Name,
                ResponsiblePersonName = vacancy.ResponsiblePerson.Name,
                WorkerTags = vacancy.Tags?.Select(t => t.ID).ToList()
            };
        }
    }
}
