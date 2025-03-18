namespace Generics.Models;

public class Camel(string name, FoodConsumtion food, int age, int humpCount) : Animal(name, food, age)
{
    public int HumpCount {get;set;} = humpCount;
}