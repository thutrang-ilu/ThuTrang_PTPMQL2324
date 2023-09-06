using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Subject
    {
        [Key]
        public string SubjectID { get; set; }
        public string SubjectName { get; set; }
    }
}