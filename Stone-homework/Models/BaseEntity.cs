using System.ComponentModel.DataAnnotations;

namespace Stone_homework.Models
{
    [Serializable]
    public abstract class BaseEntity<TKey>
    {
        [Key]
        public TKey ID { get; set; }
        public BaseEntity()
        {
            ID = default(TKey);
        }
        public BaseEntity(TKey id)
        {
            ID = id;
        }
    }
}