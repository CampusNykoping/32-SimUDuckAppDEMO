namespace SimUDuck;

public abstract class Duck      // Abstract because Display requires it
{
    //public virtual void Quack()
    //{
    //    Console.WriteLine("Duck quacks");
    //}

    //public virtual void Fly()
    //{
    //    Console.WriteLine("Duck flies");
    //}
    public void Swim()
    {
        Console.WriteLine("Duck swims");
    }

    public abstract void Display();   // Make abstract so other classes MUST override
        
    // OTHER duck-like methods here...

}
