using System.IO.Pipes;
using NewApp.Models;
public class Program
{
	private static void Main(string[] args)
	{
	//Khai báo mảng với n phần tử
	int n = 0;
	do{
		System.Console.WriteLine("Nhap kich thuoc mang: ");
		n = Convert.ToInt32(Console.ReadLine());
	}while(n<1);
	Person [] personArr = new Person[n];
	for(int i = 0; i < personArr.Length; i++)
	{
		Console.WriteLine("Nhap vao phan tu thu " + (i+1));
		//Khai báo đối tượng từ class Person
		Person ps = new Person();
		//Nhập thông tin cho đối tượng 
		ps.EnterData();
		//Gán đối tượng vào phần tử
		personArr[i] = ps;
		//Hiển thị mảng
	}
	foreach(Person p in personArr)
		{
			p.Display();
		}
	}
}