namespace Stone_homework.Models
{
    public abstract class Worker
    {
        public Guid WorkerID { get; set; }
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
        string AdditionalInfo { get; set; }//поле для заметок при приеме. При трудоустройстве при необходимости можно перенести в структурированное поле с тегами.

    }

    internal class Employee : Worker
    {
        public string Position { get; set; }
        public string Department { get; set; } //заменить сущностью при ее готовности
        public DateTime HireDate { get; set; }
    }

    internal class ReservedWorker : Worker
    {
        
    }
}
