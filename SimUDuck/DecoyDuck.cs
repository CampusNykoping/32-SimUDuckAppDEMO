namespace SimUDuck;

public class DecoyDuck : Duck
{
    public override void Quack()
    {
        // Do nothing
    }

    public override void Fly()
    {
        // Do nothing
    }
    public override void Display()
    {
        Console.WriteLine("I am a Decoy Duck");
    }
}
