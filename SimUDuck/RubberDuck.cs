namespace SimUDuck;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        flyBehavior = new FlyNoWay();
        quackBehavior = new Squeak();
    }
    public override void Display()
    {
        Console.WriteLine("I am a Rubber Duck");
    }
}
