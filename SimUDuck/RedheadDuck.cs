namespace SimUDuck;

public class RedheadDuck : Duck, IFlyable, IQuackable
{
    public virtual void Quack()
    {
        Console.WriteLine("Redhead goes Quack");
    }
    public void Fly()
    {
        Console.WriteLine("Redhead flies");
    }
    public override void Display()
    {
        Console.WriteLine("I am a Redhead");
    }
}
