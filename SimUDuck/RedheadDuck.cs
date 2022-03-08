namespace SimUDuck;

public class RedheadDuck : Duck
{
    public RedheadDuck()
    {
        FlyBehavior = new FlyWithWings();
        QuackBehavior = new Quack();
    }
    public override void Display()
    {
        Console.WriteLine("I am a Redhead");
    }
}
