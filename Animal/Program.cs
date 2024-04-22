abstract class Animal
{
    protected int Weight{get;set;}
    protected int Height{get;set;}

    public Animal(int Weight,int Height)
    {
        this.Weight = Weight;
        this.Height = Height;
    }
    public abstract void PrintInfor();
}

class Cat : Animal
{
    private string Name {get; set;}
    public Cat (int Weight,int Height,string name) : base(Weight, Height)
    {
        this.Name = name;
    }
    public override void PrintInfor()
    {
        Console.WriteLine("Weight: {0} cm" + " " + "Height: {1} cm" + " " + "Name: {2}", this.Weight, this.Height,this.Name);
    }
}

public class Program{
    public static void Main(string[] args)
{
    Cat cat = new Cat(20,15,"mimi");
    cat.PrintInfor();
}
}