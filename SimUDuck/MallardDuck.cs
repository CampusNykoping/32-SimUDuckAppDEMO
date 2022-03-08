namespace SimUDuck;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        flyBehavior = new FlyWithWings();
        quackBehavior = new Quack();
    }
    public override void Display()
    {
        Console.WriteLine("I am a Mallard");
    }
}
