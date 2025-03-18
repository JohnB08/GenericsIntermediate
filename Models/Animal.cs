namespace Generics.Models;

public class Animal(string name, FoodConsumtion food, int age)
{
    public string Name {get;set;} = name;
    public FoodConsumtion Consumtion {get;set;} = food;

    public int Age {get;set;} = age;
}
