namespace Generics.Models;

public class Bear(string name, FoodConsumtion food, int age, string coat): Animal(name, food, age)
{
    public string Coat {get;set;} = coat;
}