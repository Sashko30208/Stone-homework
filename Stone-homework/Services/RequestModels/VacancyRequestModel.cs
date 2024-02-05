namespace Stone_homework.Services.RequestModels
{
    public record VacancyRequestModel
    {
        public Guid ID { get; set; }
    }

    public record CreateVacancyModel : VacancyRequestModel
    {
        public string Name { get; set; }
        public string? EmailLink { get; set; }
        public int? DepartmentID { get; set; }
        public List<int>? WorkerTags { get; set; }
        public Guid? ResponsiblePersonID { get; set; }
    }

    public record VacancyResponseModel : VacancyRequestModel
    {
        public string Name { get; set; }
        public string? DepartmentName { get; set; }
        public string? EmailLink { get; set; }
        public List<int>? WorkerTags { get; set; }
        public string? ResponsiblePersonName { get; set; }
    }
}
