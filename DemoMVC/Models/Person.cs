using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string PersonName { get; set; }

    }
}