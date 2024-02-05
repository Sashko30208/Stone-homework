using Stone_homework.Models;

namespace Stone_homework.Services
{
    public interface IDepartmentService
    {
        Task<Department> GetDepartmentAsync(int ID);
    }
}
