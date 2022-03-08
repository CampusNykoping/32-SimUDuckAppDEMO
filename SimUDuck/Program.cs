using SimUDuck;

Duck[] ducks = new Duck[]
{
    new MallardDuck(),
    new RedheadDuck()
    
};

foreach (var duck in ducks)
{
    duck.Display();
    duck.Quack();
    Console.WriteLine();
}


Console.ReadKey();