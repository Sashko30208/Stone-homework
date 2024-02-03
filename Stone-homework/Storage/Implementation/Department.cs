using Stone_homework.Models;

namespace Stone_homework.Storage.Implementation
{
    public class DepartmentRepository : IDepartmentRepository
    {
        //private readonly VacancyContext _context;

        //public Department(VacancyContext context) => _context = context;

        public void Add(Department department)
        => throw new NotImplementedException();

        public IEnumerable<Department> GetAll()
        => throw new NotImplementedException();

        public Department GetById(int id)
            //=> context.Departments.FirstOrDefault(d => d.ID == id);
        => throw new NotImplementedException();

        public Department GetByName(string name)
        //=> context.Departments.FirstOrDefault(d => d.Name == name);

        => throw new NotImplementedException();

        public void SaveChanges()
        => throw new NotImplementedException();
    }
}
