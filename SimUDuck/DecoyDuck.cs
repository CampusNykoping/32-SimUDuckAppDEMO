namespace SimUDuck;

public class DecoyDuck : Duck
{
    public DecoyDuck()
    {
        flyBehavior = new FlyNoWay();
        quackBehavior = new MuteQuack();
    }
    public override void Display()
    {
        Console.WriteLine("I am a Decoy Duck");
    }
}
