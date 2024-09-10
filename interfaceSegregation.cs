// no client should be forced to depend on methods it does not use.
// in other words, more specific instances should be made
// instead of a general one that has all the methods

public interface IWorkable
// we make specific interfaces for specific 
// actions of the office worker
{
    void Work();
}

public interface IEatable
{
    void Eat();
}

public interface IRestable
{
    void Rest();
}

public class OfficeWorker : IWorkable, IEatable, IRestable
// here we implement the interfaces to make the office 
// worker using the different specific interfaces 
// rather than a general one
{
    public void Work()
    {
        Console.WriteLine("Office worker is working.");
    }

    public void Eat()
    {
        Console.WriteLine("Office worker is eating.");
    }

    public void Rest()
    {
        Console.WriteLine("Office worker is resting.");
    }
}

public class Robot : IWorkable
{
    public void Work()
    {
        Console.WriteLine("Robot is working.");
    }
}
