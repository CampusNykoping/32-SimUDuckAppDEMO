using SimUDuck;

Duck[] ducks = new Duck[]
{
    new MallardDuck(),
    new RedheadDuck(),
    new RubberDuck(),
    new DecoyDuck()
};

foreach (var duck in ducks)
{
    duck.Display();
    duck.PerformQuack();
    duck.PerformFly();
    Console.WriteLine();
}

Duck model = new ModelDuck();
model.Display();
model.PerformQuack();
model.PerformFly();

model.FlyBehavior = new FlyRocketPowered();
model.PerformFly();

Console.ReadKey();