namespace Stone_homework.Models
{
    [Serializable]
    public class HireStageType : BaseEntity<int>
    {
        string Name { get; set; }
        string? Description { get; set; }
    }
}