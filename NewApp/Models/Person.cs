namespace NewApp.Models
{
    public class Person
    {
       public string FullName { get; set; }
       public string Address { get; set; } 
       public int Age { get; set; }
       public int GetYearOfBirth(int age)
       {
        int yearOfBirth = 2023 - age;
        return yearOfBirth;
       }
       public void EnterData()
       {
        System.Console.Write("Full name = ");
        FullName = Console.ReadLine();
        System.Console.Write("Address = ");
        Address = Console.ReadLine();
        System.Console.Write("Age = ");
        try {
            Age = Convert.ToInt16(Console.ReadLine());
        } catch(Exception e)
        {
            Age = 0;
        }
       }
       public void Display()
       {
        System.Console.WriteLine("Ten: {0} - Dia chi: {1} - {2} tuoi",FullName, Address, Age);
       }
       public void Display2(string ten, int tuoi)
       {
        System.Console.WriteLine("Sinh vien {0} - {1} tuoi", ten, tuoi);
       }

    }
}