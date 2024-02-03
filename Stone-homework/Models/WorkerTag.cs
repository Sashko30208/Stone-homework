namespace Stone_homework.Models
{
    public class WorkerTag
    {
        public int TagID { get; set; }
        public string Description { get; set; }
        public string TagGroup { get; set; } //туду отдельная сущность с ценностью (софт скиллс, знание технологий, особенности взаимодействия (часовой пояс, м.б. инвалидность..) и тд)
        public byte TagValue { get; set; }//Важность указанного умения, способности.
                                          //Например, можно поместить в теги знание css и возможность удаленной работы.
                                          //Знание css не поможет, если ищется человек в конкретный офис,
                                          // а соискатель с другого конца страны и переезжать не планирует.
    }
}