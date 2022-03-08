namespace SimUDuck;

public abstract class Duck      // Abstract because Display requires it
{
    private IFlyBehavior? flyBehavior;
    private IQuackBehavior? quackBehavior;

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

    public IFlyBehavior? FlyBehavior { set => flyBehavior = value; }
    public IQuackBehavior? QuackBehavior { set => quackBehavior = value; }

    // OTHER duck-like methods here...

}
