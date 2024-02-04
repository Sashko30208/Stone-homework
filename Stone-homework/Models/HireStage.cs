using System.ComponentModel.DataAnnotations.Schema;

namespace Stone_homework.Models
{
    [Table("HireStages")]
    [Serializable]
    public class HireStage : BaseEntity<int>
    {
        public byte StageNumber { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public string? OptionalFileName { get; set; }//в реальном проекте можно завязаться на id файла в системе, но похоже что уже и так сильно усложнено.
        [ForeignKey(nameof(HireStageType))]
        public int StageTypeID { get; set; }
        public HireStageType StageType { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string? ExecutionResult { get; set; } //не уверен что требуется. Некоторые этапы не требуют оценки, а у каких-то можно делать доп. пометки.
    }
}
