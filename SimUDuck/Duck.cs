namespace SimUDuck;

public class Duck
{
    public void Quack()
    {
        Console.WriteLine("Duck goes Quack");
    }

    public void Swim()
    {
        Console.WriteLine("Duck swims");
    }

    public virtual void Display()   // Make virtual so other classes can override
    {
        Console.WriteLine("I am a Duck");
    }

    // OTHER duck-like methods here...

}
