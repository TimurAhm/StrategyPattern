internal class Program
{
    private static void Main(string[] args)
    {
        Car auto = new Car(400, "Toyota", new PetrolMove());
        auto.Move(auto);
        auto.Movable = new ElectricMove();
        auto.Move(auto);
    }
}

//public interface IStrategy
//{
//    void Algorithm();
//}

//public class ConcreteStrategy1 : IStrategy
//{
//    public void Algorithm()
//    {

//    }
//}

//public class ConcereteStrategy : IStrategy
//{
//    public void Algorithm()
//    {

//    }
//}

//public class Context
//{
//    public IStrategy ContextStrategy { get; set; }

//    public Context(IStrategy _strategy) 
//    {
//        ContextStrategy = _strategy;
//    }

//    public void ExecuteAlgorithm()
//    {
//        ContextStrategy.Algorithm();
//    }
//}

interface IMovable
{
    void Move(Car car);
}

internal class PetrolMove : IMovable
{
    public void Move(Car car)
    {
        Console.WriteLine($"Перемещение на бензе, расход - {car.cost / 10} литров на 100км.");
    }
}

internal class ElectricMove : IMovable
{
    public void Move(Car car)
    {
        Console.WriteLine($"Перемещение на электричествеб расход - {car.cost / 100} киловатт на 100км");
    }
}

internal class Car
{
    public int cost;
    protected string model;

    public Car(int num, string model, IMovable mov)
    {
        this.cost = num;
        this.model = model;
        Movable = mov;
    }

    public IMovable Movable { get; set; }
    public void Move(Car car)
    {
        Movable.Move(car);
    }
}