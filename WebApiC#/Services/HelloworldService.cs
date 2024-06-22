public class HelloWorldService : IHelloWorldService
{
    public string GetHelloWorld()
    {
        return "Hello World!";
    }
    public string GetHelloWorldNoAccesible()
    {
        return "Este servicio no es accesible";
    }
}

public interface IHelloWorldService
{
    string GetHelloWorld();
}