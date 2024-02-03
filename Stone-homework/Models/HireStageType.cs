namespace Stone_homework.Models
{
    [Serializable]
    public class HireStageType
    {
        [System.ComponentModel.DataAnnotations.Key]
        int ID { get; set; }
        string Name { get; set; }
        string? Description { get; set; }
    }
}