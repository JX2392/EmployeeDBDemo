using System.ComponentModel.DataAnnotations;

namespace EmployeeDBDemo.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Department { get; set; }
    }
}
