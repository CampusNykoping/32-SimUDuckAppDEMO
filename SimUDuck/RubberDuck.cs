namespace SimUDuck;

public class RubberDuck : Duck
{
    public override void Quack()
    {
        Console.WriteLine("Rubber Duck goes Squeak");
    }

    public override void Fly()
    {
        // Do nothing
    }
    public override void Display()
    {
        Console.WriteLine("I am a Rubber Duck");
    }
}
