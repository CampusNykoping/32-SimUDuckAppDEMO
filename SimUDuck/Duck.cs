namespace SimUDuck;

public abstract class Duck      // Abstract because Display requires it
{
    internal IFlyBehavior? flyBehavior;
    internal IQuackBehavior? quackBehavior;

    public void PerformQuack()
    {
        quackBehavior.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("Duck swims");
    }

    public abstract void Display();   // Make abstract so other classes MUST override
    

    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    // OTHER duck-like methods here...

}
