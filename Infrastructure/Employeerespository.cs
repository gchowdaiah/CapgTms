using TicketManagementSystem.Models;

namespace TicketManagementSystem.Infrastructure
{
    public class EmployeeRepository : ICRUDRepository<Employee, int>
    {
        public void Create(Employee item)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAll()
        {
            throw new NotImplementedException();
        }

        public Employee GetDetails(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Employee item)
        {
            throw new NotImplementedException();
        }
    }
}