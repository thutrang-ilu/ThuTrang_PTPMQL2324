﻿// See https://aka.ms/new-console-template for more information
// 4 lệnh nhập xuất dữ liệu 
/* 1 Console.Write("Hello, World!");
Console.WriteLine("Hello, World!");
Console.Write(6);
int a = 9; 
Console.WriteLine("a = " + a);
	int b = 3;
Console.WriteLine("{0} + {1} = {2}", a, b, a+b); */
/* 2 internal class vidu
{
	private static void Main(string[] args)
	{
		Console.Write("Nhap vao du lieu: ");
		string str = Console.ReadLine();
		Console.WriteLine("Du lieu vưa nhap vao là: " + str);

	}
} */
/* 3 internal class vidu
{
	private static void Main(string[] args)
	{
		//Khai bao bien kieu string va gan gia tri = Nguyen Van A
		string hoTen = "Nguyen Van A";
		//Khai bao bien kieu in va gan gia trị = 18
		int tuoi = 18;
		Console.WriteLine("Sinh vien {0} - {1} tuoi",hoTen,tuoi);
	}
}*/
/* Hằng số 
internal class vidu1
{
	private static void Main(string[] args)
	{
		//Khai bao bien kieu string va gan gia tri = Nguyen Van A
		const string hoTen = "Nguyen Van A";
		//Khai bao bien kieu in va gan gia trị = 18
		const int namLamViec = 8;
		const long tuoi = 32;
		Console.WriteLine("Nhan vien {0} - {1} nam kinh nghiem - {2} tuoi",hoTen,namLamViec,tuoi);
	}
} */
/* Chuyển đổi dữ liệu
internal class vidu1
{
	private static void Main(string[] args)
	{
		int a = 10;
		float b = a;
		System.Console.WriteLine("b = " + b);
	}
}*/
/* chuyển đổi bằng Parse
internal class vidu1
{
	private static void Main(string[] args)
	{
		string str = "123";
		int a = int.Parse(str);
		System.Console.WriteLine("a = " + a);
	}
}   */
/* chuyển đổi bằng TryParse
internal class vidu1
{
	private static void Main(string[] args)
	{
		string str = "123";
		int ketQua;
		bool kiemTra = false;
		kiemTra = int.TryParse(str,out(ketQua));
		System.Console.WriteLine("Ket qua = " + ketQua);
	}
}    */
internal class vidu1
{
	private static void Main(string[] args)
	{
		string str = "123";
		//chuyển đổi kiểu dữ liệu string sang int
		int a = Convert.ToInt32(str);
		System.Console.WriteLine("a = " + a);
	}
}

