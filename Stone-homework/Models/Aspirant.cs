namespace Stone_homework.Models
{
    public abstract class Worker : BaseEntity<Guid>
    {
        public string Name { get; set; }
        public string? Surname { get; set; }
        public string Patronymic { get; set; }
        string PhoneNumber { get; set; }//контактные данные тоже можно вынести в отдельную сущность
        public WorkerStatus Status { get; set; }//статус работника (на рассмотрении, уже работает, в "запасе")
        public List<WorkerTag> Tags { get; set; }

    }

    internal class Aspirant : Worker
    {
        string EMail { get; set; }
        DateTime RequestDate { get; set; }
        string AdditionalInfo { get; set; }//поле для заметок при приеме.
                                           //При трудоустройстве при необходимости можно перенести в структурированное поле с тегами.
        public List<HireStage> hireStages { get; set; }//назначенные и пройденные этапы трудоустройства
    }

    internal class Employee : Worker
    {
        public string Position { get; set; }
        public Department Department { get; set; }
        public DateTime HireDate { get; set; }
    }

    internal class ReservedWorker : Worker
    {

    }
}
