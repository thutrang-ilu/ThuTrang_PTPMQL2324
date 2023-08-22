namespace NewApp.Models
{
    public class Student
    {
        public string StudentID { get; set; }
       public string StudentName { get; set; } 
       public int StudentAge { get; set; }
       public void EnterData()
       {
        System.Console.Write("Ma sinh vien = ");
        StudentID = Console.ReadLine();
        System.Console.Write("Ten sinh vien = ");
        StudentName = Console.ReadLine();
        System.Console.Write("Tuoi = ");
        StudentAge = Convert.ToInt16(Console.ReadLine());
       }
        public void Display()
       {
        System.Console.WriteLine("Ma sinh vien: {0} - Ten sinh vien: {1} - Tuoi: {2}",StudentID, StudentName, StudentAge);
       }
    }
}