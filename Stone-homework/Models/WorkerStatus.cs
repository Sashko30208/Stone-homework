namespace Stone_homework.Models
{
    public class WorkerStatus
    {
        public int WorkerStatusID { get; set; }
        public string StatusDescription { get; set; }
    }

    //public class WorkerStatus
    //{
    //    // только для прототипирования. Должно браться из базы.
    //    public static Dictionary<short, string> WorkerStatuses = new()
    //    {
    //        {0, "Отправлено приглашение" },
    //        {1, "Выполняет опциональные этапы" },
    //        {2, "Направлен на собеседование" },
    //        {3, "на утверждении кандидатуры" },
    //        {4, "проходит проверку безопасности или бюрократия" },
    //        {5, "на испытательном сроке" },
    //        {6, "принят в постоянный штат" },
    //        {7, "кандидатура отклонена" },
    //        {8, "уже не работает"}
    //    };

    //}
    //public enum WorkerStatus
    //{
    //    requestSended,
    //    DoingOptionalStages
    //}
}