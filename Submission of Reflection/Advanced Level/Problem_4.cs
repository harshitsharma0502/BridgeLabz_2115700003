using System;
using System.Linq;
using System.Reflection;

[AttributeUsage(AttributeTargets.Constructor)]
public class InjectAttribute : Attribute { }

public interface IService
{
    void Serve();
}

public class Service : IService
{
    public void Serve()
    {
        Console.WriteLine("Service is running...");
    }
}

public class Consumer
{
    private readonly IService _service;

    [Inject]
    public Consumer(IService service)
    {
        _service = service;
    }

    public void Execute()
    {
        _service.Serve();
    }
}

public class DIContainer
{
    public static T Resolve<T>()
    {
        Type type = typeof(T);
        ConstructorInfo constructor = type.GetConstructors()
            .FirstOrDefault(c => c.GetCustomAttribute<InjectAttribute>() != null);

        if (constructor == null)
            throw new Exception("No suitable constructor found with [Inject] attribute.");

        ParameterInfo[] parameters = constructor.GetParameters();
        object[] paramInstances = parameters.Select(p => Activator.CreateInstance(p.ParameterType)).ToArray();

        return (T)constructor.Invoke(paramInstances);
    }
}

class Program
{
    static void Main()
    {
        Consumer consumer = DIContainer.Resolve<Consumer>();
        consumer.Execute();
    }
}
