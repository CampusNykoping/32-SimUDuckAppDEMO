﻿using SimUDuck;

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
    duck.Quack();
    duck.Fly();
    Console.WriteLine();
}

var mallard = new MallardDuck();
mallard.Fly();
mallard.Quack();

Console.ReadKey();