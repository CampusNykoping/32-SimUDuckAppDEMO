namespace SimUDuck;

public class MallardDuck : Duck, IFlyable, IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Mallard goes Quack");
    }

    public void Fly()
    {
        Console.WriteLine("Mallard flies");
    }

    public override void Display()
    {
        Console.WriteLine("I am a Mallard");
    }
}
