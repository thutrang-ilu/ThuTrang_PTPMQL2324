using System.Data;

namespace NewApp.Models
{
    public class Employee : Person
    {
        Employee[] empArray = new Employee[7];
        public int Luong { get; set; }
        public void EnterData()
        {
            base.EnterData();
            System.Console.Write("Luong = ");
            Luong = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
       {
        base.Display();
        System.Console.Write("Luong: {0}", Luong);
       }
    }
}