using System.ComponentModel.DataAnnotations.Schema;

namespace Stone_homework.Models
{
    //мысль сделать базовую вакансию и от нее конкретные с разными ссылками на сайты отбросил
    //т.к. это усложнение, которое, вероятно, не требуется.
    public class Vacancy : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime CloseDate { get; set; }
        public string EmailLink { get; set; }
        [ForeignKey(nameof(Department))]
        public int DepartmentID { get; set; }
        public Department Department { get; set; }
        public List<WorkerTag> Tags { get; set; }//по этим тегам можно делать предварительную выборку наиболее
                                                 //подходящих кандидатов из базы и искать похожие существующие вакансии.
        [ForeignKey(nameof(Employee))]
        public Guid ResponsiblePersonID { get; set; }
        internal Employee ResponsiblePerson { get; set; }
    }
}
