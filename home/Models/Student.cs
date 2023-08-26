namespace Home.Models
{
    //Day la tao class
    public class Student
    {
        //Phuong thuc co trong class
        public string StudentID { get; set; }
        public string Fullname { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
        //Phuong thuc nhap va hien thi
        public void EnterData()
        {
            System.Console.Write("Nhap ma sinh vien: ");
            StudentID = Console.ReadLine();
            System.Console.Write("Nhap ten sinh vien: ");
            Fullname = Console.ReadLine();
            System.Console.Write("Nhap dia chi: ");
            Adress = Console.ReadLine();
            System.Console.Write("Tuoi: ");
            Age = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("Sdt: ");
            Phone = Convert.ToInt32(Console.ReadLine());
        }
        public void Display()
        {
            System.Console.WriteLine("Msv: {0} - Ten: {1} - Dia chi: {2} - Tuoi: {3} - Sdt: 0{4} ",StudentID, Fullname, Adress, Age, Phone);
        }
    }
}
