using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }

    }
}