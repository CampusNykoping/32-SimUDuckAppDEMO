namespace SimUDuck;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        FlyBehavior = new FlyWithWings();
        QuackBehavior = new Quack();
    }
    public override void Display()
    {
        Console.WriteLine("I am a Mallard");
    }
}
