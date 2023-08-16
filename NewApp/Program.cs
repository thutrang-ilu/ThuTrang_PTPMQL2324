/*public class Program
{
	private static void Main(string[] args)
	{
		int day = 10;
		switch(day)
		{
			case 1: System.Console.WriteLine("Chu nhat"); break;
			case 2: System.Console.WriteLine("Thu 2"); break;
			case 3: System.Console.WriteLine("Thu 3"); break;
			case 4: System.Console.WriteLine("Thu 4"); break;
			case 5: System.Console.WriteLine("Thu 5"); break;
			case 6: System.Console.WriteLine("Thu 6"); break;
			case 7: System.Console.WriteLine("Thu 7"); break;
			default :
				System.Console.WriteLine("Không phai ngay trong tuan");
				break;
		}
	}
}    */
/* Vòng for
public class Program
{
	private static void Main(string[] args)
	{
		for(int i =0; i<10; i++)
		{
			System.Console.WriteLine("Vong lap thu {0}",i);
		}
	}
}    */
/* Vòng While
public class Program
{
	private static void Main(string[] args)
	{
		int a = 1;
		while(a < 5)
		{
			System.Console.WriteLine("Vong lap thu {0}",a);
			a++;
		}
	}
}       */
/* Vòng do...while
public class Program
{
	private static void Main(string[] args)
	{
		int a = 1;
		do
		{
			System.Console.WriteLine("Vong lap thu {0}",a);
			a++;
		}
		while(a < 5);
		
	}
}    */
/*
public class Program
{
	private static void Main(string[] args)
	{
		for(int i = 0; i < 10; i++)
		{
			if(i==5) break;
			System.Console.WriteLine("Vong lap thu {0}", i);
		}
	}
}  */
public class Program
{
	private static void Main(string[] args)
	{
		for(int i = 0; i < 10; i++)
		{
			if(i==5) continue;
			System.Console.WriteLine("Vong lap thu {0}", i);
		}
	}
}