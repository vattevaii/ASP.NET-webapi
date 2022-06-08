using asp.net_folder.Models;

namespace asp.net_folder.Services;

public static class EmployeeService
{
   static List<Employee> Employees { get; }
   static int nextId = 4;
   static EmployeeService()
   {
      Employees = new List<Employee>{
         new Employee{
            Id=1,StartedFrom=DateTime.Now.AddMonths(-2), FirstName="Ashish", LastName="Bhattarai"
         },new Employee{
            Id=2,StartedFrom=DateTime.Now.AddMonths(-3), FirstName="Pawan", LastName="Bhatta"
         },new Employee{
            Id=3,StartedFrom=DateTime.Now.AddMonths(-1), FirstName="Rupesh", LastName="Gyawali"
         },
      };
   }
   public static List<Employee> GetAll() => Employees;

   public static Employee? GetById(int id) => Employees.FirstOrDefault(e => e.Id == id);

   public static Employee Add(Employee employee)
   {
      employee.Id = nextId++;
      Employees.Add(employee);
      return employee;
   }

   public static Employee? Update(Employee employee)
   {
      var existing = GetById(employee.Id);
      if (existing == null)
         return null;
      existing.FirstName = employee.FirstName;
      existing.LastName = employee.LastName;
      return existing;
   }

   public static Employee? UpdateHoliday(int id)
   {
      var existing = GetById(id);
      if (existing == null)
         return null;
      existing.OnHoliday = !existing.OnHoliday;
      return existing;
   }
}