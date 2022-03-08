namespace SimUDuck;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new Squeak();
    }
    public override void Display()
    {
        Console.WriteLine("I am a Rubber Duck");
    }
}
