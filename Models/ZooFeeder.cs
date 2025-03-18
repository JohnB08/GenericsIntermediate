using Generics.Interfaces;

namespace Generics.Models;

public class ZooFeeder
{
    public static void Feed(IAnimalPopper<Animal> animals)
    {
        for (int i = 0; i < animals.Count(); i++)
        {
            var animal = animals.Pop();
            var food = animal.Consumtion switch
            {
                FoodConsumtion.Herbivore => "a fresh salad.",
                FoodConsumtion.Carnivore => "a nice, juicy salmon",
                FoodConsumtion.Omnivore => "anything we could find, really",
                _ => "this foodtype is not registered"
            };
            Console.WriteLine($"Fed animal {animal.Name} {food}");
        }
    }
}