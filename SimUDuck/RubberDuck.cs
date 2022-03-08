namespace SimUDuck;

public class RubberDuck : Duck, IQuackable
{
    public void Quack()
    {
        Console.WriteLine("Rubber Duck goes Squeak");
    }
    
    public override void Display()
    {
        Console.WriteLine("I am a Rubber Duck");
    }
}
