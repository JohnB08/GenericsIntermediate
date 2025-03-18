using Generics.Interfaces;

namespace Generics.Models;

public class AnimalPen<T>(int animalCount): IAnimalPopper<T>, IAnimalPusher<T>
{
    private int _position;

    private T[] _pen {get;init;} = new T[animalCount];

    public void Push(T animal) => _pen[_position++] = animal;

    public T Pop() => _pen[--_position];
    public int Count() => _pen.Count(animal => animal != null);

    public T this [int index] => _pen[index];

}