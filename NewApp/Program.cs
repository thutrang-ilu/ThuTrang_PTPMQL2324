/*public class Program
{
	private static void Main(string[] args)
	{
		int a,b;
		//thong bao nguoi dung nhap vao a
		System.Console.Write("a = ");
		a = Convert.ToInt32(Console.ReadLine());
		System.Console.Write("b = ");
		b = Convert.ToInt32(Console.ReadLine());
		//in tong a+b
		System.Console.WriteLine("Tong 2 so:{0}+{1}={2}", a,b,a+b);
		System.Console.WriteLine("Hieu 2 so {0}-{1}={2}", a,b,a-b);
		System.Console.WriteLine("Tich 2 so {0}*{1}={2}", a,b,a*b);
		int c,d;
		System.Console.Write("c = ");
		c = Convert.ToInt32(Console.ReadLine());
		System.Console.Write("d = ");
		d = Convert.ToInt32(Console.ReadLine());
		System.Console.WriteLine("Chia lay nguyen {0}/{1}={2}", c,d,c/d);
		System.Console.WriteLine("Chia lay du {0}%{1}={2}", c,d,c%d);
	}
}*/
public class Program
{
	private static void Main(string[] args)
	{
		float a =2;
		if(a >=8){
			System.Console.WriteLine("Hoc luc gioi");
		}else if (a >= 6.5){
			System.Console.WriteLine("Hoc luc kha");
		}else if (a >= 5){
			System.Console.WriteLine("Hoc luc trung binh");
		}else if (a >= 3.5){
			System.Console.WriteLine("Hoc luc yeu");
		}else {
			System.Console.WriteLine("Hoc luc kem");
		}
	}
}
