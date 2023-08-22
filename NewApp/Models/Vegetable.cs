namespace NewApp.Models
{
    public class Vegetable : Fruit
    {
        public string Nguon { get; set; }
        public void EnterData()
    {
        //ke thua lai o class Fruit
        base.EnterData();
        // nhap thong tin vegetable code
        System.Console.Write("Nguon nhap: ");
        Nguon = Console.ReadLine();
    }
    public void Display()
    {
        //Ke thua class Fruit
        base.Display();
        //Nhap thong tin Vegetable code
        System.Console.Write("Nguon nhap: {0}", Nguon);
    }
    }
}