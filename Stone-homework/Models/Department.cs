namespace Stone_homework.Models
{
    public class Department : BaseEntity<int>
    {
        public string Name { get; set; }
        public List<Worker> Workers { get; set; }
    }
}
