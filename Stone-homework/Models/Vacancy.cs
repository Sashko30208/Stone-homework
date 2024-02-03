namespace Stone_homework.Models
{
    //мысль сделать базовую вакансию и от нее конкретные с разными ссылками на сайты отбросил
    //т.к. это усложнение, которое, вероятно, не требуется.
    public class Vacancy
    {
        Guid VacancyID { get; set; }
        public string VacancyName { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string VacancyLink { get; set; }
        public string Department { get; set; }//пока просто текстовым полем, но, по хорошему, нужна отдельная сущность.
        public List<WorkerTag> Tags { get; set; }//по этим тегам можно делать предварительную выборку наиболее
                                                 //подходящих кандидатов из базы и искать похожие существующие вакансии.
        internal Employee ResponsiblePerson { get; set; }
    }
}
