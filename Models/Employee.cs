namespace asp.net_folder.Models;

public class Employee
{
   public int Id { get; set; }
   public DateTime StartedFrom { get; set; }

   public string? FirstName { get; set; }

   public string? LastName { get; set; }

   public bool OnHoliday { get; set; }

   // public Employee()
   // {
   //    // StartedFrom = DateTime.Now;
   //    FirstName = "";
   //    LastName = "";
   // }
   // public Employee(DateTime startedFrom, string firstName, string lastName)
   // {
   //    StartedFrom = startedFrom;
   //    FirstName = firstName;
   //    LastName = lastName;
   // }
   // public Employee(DateTime startedFrom, string firstName, string lastName, bool? onHoliday)
   // {
   //    StartedFrom = startedFrom;
   //    FirstName = firstName;
   //    LastName = lastName;
   //    OnHoliday = onHoliday;
   // }
}
