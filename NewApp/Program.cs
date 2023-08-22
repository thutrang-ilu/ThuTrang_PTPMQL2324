using NewApp.Models;
public class Program
{
	private static void Main(string[] args)
	{
		//Khoi tao 2 doi tuong tu class Person
		Person ps1 = new Person();
		Person ps2 = new Person();
		//gan gia tri cho thuoc tinh doi tuong ps1
		ps1.FullName = "Nguyen Van A";
		ps1.Address = "Ha Noi";
		ps1.Age = 18;
		// Goi phuong thuc hien thi thong tin
		ps1.Display();
	}
}