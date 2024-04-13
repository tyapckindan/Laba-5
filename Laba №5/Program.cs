class Animal
{
    public string name, 
        food, 
        location;

    public Animal(string food, string location, string name)
    {
        this.food = food;
        this.location = location;
        this.name = name;
    }

    public virtual void makeNoise() => Console.WriteLine($"{name} спит.");
    public virtual void Food() => Console.WriteLine($"{name} ест {food}.");
}

class Dog : Animal
{
    string collar;
    public Dog(string food, string location, string name, string collar) : base(food, location, name)
    {
        this.collar = collar;
    }
    public override void makeNoise() => Console.WriteLine("Собака спит.");
    public override void Food() => Console.WriteLine($"Собака ест {food}.");
}

class Cat : Animal
{
    string hostes;
    public Cat(string food, string location, string name, string hostes) : base(food, location, name)
    {
        this.hostes = hostes;
    }
    public override void makeNoise() => Console.WriteLine("Кошка спит.");
    public override void Food() => Console.WriteLine($"Кошка ест {food}.");
}

class Horse : Animal
{
    string barn;
    public Horse(string food, string location, string name, string barn) : base(food, location, name)
    {
        this.barn = barn;
    }
    public override void makeNoise() => Console.WriteLine("Лошадь спит.");
    public override void Food() => Console.WriteLine($"Лошадь ест {food}.");
}

class Veterinarian
{
    public void threadAnimal(Animal animal) => Console.WriteLine($"{animal.name} ест {animal.food} и живёт в {animal.location}");
}
internal class Program
{
    private static void Main(string[] args)
    {
        Dog dog = new("Мясцо", "Конура", "Дружок", "Нет");
        Cat cat = new("Рыба", "Дом", "Мурка", "Сама себе хозяйка");
        Horse horse = new("Овёс", "Сарай", "Брюква", "Да");
        Veterinarian veterinarian = new();

        veterinarian.threadAnimal(dog);
        veterinarian.threadAnimal(cat);
        veterinarian.threadAnimal(horse);
    }
}