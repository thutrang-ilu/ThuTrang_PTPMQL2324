using System.ComponentModel.DataAnnotations;

namespace DemoMVC.Models
{
    public class Customer
    {
        [Key]
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }


    }
}