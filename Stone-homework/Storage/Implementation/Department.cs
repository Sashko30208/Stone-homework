using Stone_homework.Models;

namespace Stone_homework.Storage.Implementation
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly ApplicationDbContext _context;

        public DepartmentRepository(ApplicationDbContext context)
            => _context = context;

        public void Add(Department department)
        => throw new NotImplementedException();

        public IEnumerable<Department> GetAll()
        => throw new NotImplementedException();

        public Department GetById(int id)
        => _context.Departments.FirstOrDefault(d => d.ID == id);

        public Department GetByName(string name)
        //=> context.Departments.FirstOrDefault(d => d.Name == name);

        => throw new NotImplementedException();

        public void SaveChanges()
        => throw new NotImplementedException();
    }
}
