namespace SimUDuck;

public abstract class Duck      // Abstract because Display requires it
{
    public virtual void Quack()
    {
        Console.WriteLine("Duck goes Quack");
    }

    public void Swim()
    {
        Console.WriteLine("Duck swims");
    }

    public abstract void Display();   // Make abstract so other classes MUST override
    

    public virtual void Fly()
    {
        Console.WriteLine("Duck flies");
    }

    // OTHER duck-like methods here...

}
