using System;
using System.Reflection;

public interface IGreeting
{
    void SayHello(string name);
}

public class Greeting : IGreeting
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }
}

public class LoggingProxy<T> : DispatchProxy
{
    private T _instance;

    public static T Create(T instance)
    {
        T proxy = Create<T, LoggingProxy<T>>();
        (proxy as LoggingProxy<T>)._instance = instance;
        return proxy;
    }

    protected override object Invoke(MethodInfo targetMethod, object[] args)
    {
        Console.WriteLine($"[LOG] Method Called: {targetMethod.Name}");
        return targetMethod.Invoke(_instance, args);
    }
}

class Program
{
    static void Main()
    {
        IGreeting greetingProxy = LoggingProxy<IGreeting>.Create(new Greeting());
        greetingProxy.SayHello("Alice");
    }
}
