using Stone_homework.Models;

namespace Stone_homework.Storage.Implementation
{
    public class DepartmentRepository : Base.Repository<int, Department, ApplicationDbContext>, IDepartmentRepository
    {
        public DepartmentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}
