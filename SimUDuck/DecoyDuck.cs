namespace SimUDuck;

public class DecoyDuck : Duck
{
    public DecoyDuck()
    {
        FlyBehavior = new FlyNoWay();
        QuackBehavior = new MuteQuack();
    }
    public override void Display()
    {
        Console.WriteLine("I am a Decoy Duck");
    }
}
