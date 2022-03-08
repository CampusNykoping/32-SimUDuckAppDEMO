namespace SimUDuck;

public class RedheadDuck : Duck
{
    public RedheadDuck()
    {
        flyBehavior = new FlyWithWings();
        quackBehavior = new Quack();
    }
    public override void Display()
    {
        Console.WriteLine("I am a Redhead");
    }
}
