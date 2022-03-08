namespace SimUDuck;

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Console.WriteLine("Squeaks...");
    }
}
