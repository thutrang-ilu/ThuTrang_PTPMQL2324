using System.IO.Pipes;
using NewApp.Models;
public class Program
{
	private static void Main(string[] args)
	{
	//Khai báo mảng với n phần tử
	int n = 0;
	do{
		try {
			System.Console.WriteLine("Nhap kich thuoc mang: ");
			n = Convert.ToInt32(Console.ReadLine());
		} catch(Exception e)
		{
			n = 0;
		}
	}while(n<1);
	Student [] stdArr = new Student[n];
	for(int i = 0; i < stdArr.Length; i++)
	{
		Console.WriteLine("Nhap vao phan tu thu: "+ (i+1));
		//Khởi tạo 1 đối tượng từ class
		Student std = new Student();
		//Nhập thông tin cho đối tượng
		std.EnterData();
		//Gán đối tượng vao phần tử
		stdArr[i]  = std;
	}
	//Hiển thị
	foreach (Student std in stdArr)
	{
		std.Display();
	}

	}
}