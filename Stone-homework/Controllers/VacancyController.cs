using Microsoft.AspNetCore.Mvc;
using Stone_homework.Models;
using Stone_homework.Services;
using Stone_homework.Services.RequestModels;

namespace Stone_homework.Controllers
{
    [Route("[controller]")]
    public class VacancyController : Controller
    {
        private IVacancyService _vacancyService;
        public VacancyController(IVacancyService service)
        {
            _vacancyService = service;
        }

        [HttpPost(nameof(GetVacancy))]
        public async Task<VacancyResponseModel> GetVacancy([FromBody] VacancyRequestModel requestModel)
        {
            return await _vacancyService.GetVacancyAsync(requestModel.ID);
        }

        [HttpPost(nameof(CreateVacancy))]
        public async Task<VacancyResponseModel> CreateVacancy([FromBody]CreateVacancyModel createModel)
        {
            return await _vacancyService.CreateVacancyAsync(createModel);
        }
    }
}
